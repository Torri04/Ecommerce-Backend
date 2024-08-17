using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Extensions;
using ASP.NET_API.Helpers;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ASP.NET_API.Controller;

[Route("api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly ITokenService _tokenService;
    private readonly IEmailSender _emailSender;
    private readonly IMapper _mapper;
    private readonly LinkGenerator _linkGenerator;
    private readonly IAzureQueueService _azureQueueService;


    public AccountController(IAzureQueueService azureQueueService, UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager, ITokenService tokenService, IEmailSender emailSender, LinkGenerator linkGenerator)
    {
        _tokenService = tokenService;
        _signInManager = signInManager;
        _userManager = userManager;
        _mapper = mapper;
        _emailSender = emailSender;
        _linkGenerator = linkGenerator;
        _azureQueueService = azureQueueService;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> SignUp([FromBody] PostSignUpDto postRegisterDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var appUser = _mapper.Map<AppUser>(postRegisterDto);
        var userResult = await _userManager.CreateAsync(appUser, postRegisterDto.Password);

        if (userResult.Succeeded)
        {
            var roleResult = await _userManager.AddToRoleAsync(appUser, "User");

            if (roleResult.Succeeded)
            {
                var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
                emailToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(emailToken));

                var callbackUrl = _linkGenerator.GetUriByAction(HttpContext, "VerifyEmail", "Account",
                new EmailQuery { UserId = appUser.Id, EmailToken = emailToken }, Request.Scheme);

                var emailContent = new
                {
                    UserEmail = appUser.Email,
                    Subject = "Xác nhận địa chỉ Email",
                    HtmlMessage = $"Hãy xác nhận địa chỉ Email bằng cách <a href='{callbackUrl}'>Bấm vào đây</a>."
                };

                await _azureQueueService.SendMessageAsync(JsonConvert.SerializeObject(emailContent), "email-queue");

                return Ok("User has been created");
            }
            return StatusCode(500, roleResult.Errors);
        }
        return StatusCode(500, userResult.Errors);
    }

    [HttpGet("verifyemail")]
    public async Task<IActionResult> VerifyEmail([FromQuery] EmailQuery emailQuery)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var appUser = await _userManager.FindByIdAsync(emailQuery.UserId);

        if (appUser == null)
            return NotFound("User not found");

        var emailCode = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(emailQuery.EmailToken));
        var result = await _userManager.ConfirmEmailAsync(appUser, emailCode);

        if (result.Succeeded)
            return Ok("Email has been verified");

        return StatusCode(500, result.Errors);
    }

    [HttpPost("signin")]
    public async Task<IActionResult> SignIn([FromBody] PostSignInDto postSignInDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = _userManager.Users.FirstOrDefault(x => x.UserName == postSignInDto.UserName.ToLower().Trim());

        if (user == null)
            return Unauthorized("Username is invalid");

        if (!await _userManager.IsEmailConfirmedAsync(user))
            return Unauthorized("Email has not been verified");

        var result = await _signInManager.CheckPasswordSignInAsync(user, postSignInDto.Password, false);

        if (!result.Succeeded)
            return Unauthorized("Password is incorrect");

        var roles = await _userManager.GetRolesAsync(user);
        var role = roles.FirstOrDefault();
        var refreshToken = await _tokenService.GetRefreshTokenAsync(user);

        if (refreshToken != null)
        {
            if (await _tokenService.IsRefreshTokenExpiriedAsync(user))
            {
                refreshToken = await _tokenService.UpdateRefreshTokenAsync(user);
            }
        }
        else
        {
            refreshToken = await _tokenService.CreateRefreshTokenAsync(user);
        }

        return Ok(
            new GetUserTokenDto
            {
                Token = _tokenService.CreateToken(user, role),
                RefreshToken = refreshToken.Token,
            }
        );
    }

    [HttpPost("getnewtoken")]
    [Authorize]
    public async Task<IActionResult> GetRefreshToken([FromBody] string refreshToken)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);

        if (user == null)
            return Unauthorized("User not found");

        var _refreshToken = await _tokenService.GetRefreshTokenAsync(user);

        if (_refreshToken.Token != refreshToken)
            return BadRequest("RefreshToken is not the same");

        if (await _tokenService.IsRefreshTokenExpiriedAsync(user))
            return BadRequest("RefreshToken expired");

        var roles = await _userManager.GetRolesAsync(user);
        var role = roles.FirstOrDefault();
        var token = _tokenService.CreateToken(user, role);

        return Ok(new { Token = token });
    }

    [HttpPost("forgotpassword")]
    public async Task<IActionResult> ForgotPassword([FromBody] PostForgotPasswordDto model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == model.UserName);

        if (user == null)
            return NotFound("Username not found");

        if (user.Email != model.Email)
            return BadRequest("Username not match with email");

        if (!(await _userManager.IsEmailConfirmedAsync(user)))
            return BadRequest("Email not confirmed");

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

        var callbackUrl = _linkGenerator.GetUriByAction(HttpContext, "ResetPassword", "Account", new { token = token, email = user.Email }, Request.Scheme);

        var emailContent = new
        {
            UserEmail = user.Email,
            Subject = "Quên mật khẩu",
            HtmlMessage = $"Hãy xác nhận quên mật khẩu bằng cách <a href='{callbackUrl}'>Bấm vào đây</a>."
        };

        await _azureQueueService.SendMessageAsync(JsonConvert.SerializeObject(emailContent), "email-queue");

        return Ok("ResetPassword has been sent to your email");
    }

    [HttpPost("resetpassword")]
    public async Task<IActionResult> ResetPassword([FromBody] PostResetPasswordDto model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await _userManager.FindByEmailAsync(model.Email);

        if (user == null)
            return BadRequest("Password reset failed");

        var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(model.Token));
        var result = await _userManager.ResetPasswordAsync(user, token, model.Password);

        if (result.Succeeded)
            return Ok("Password has been reset successfully");

        foreach (var error in result.Errors)
            ModelState.AddModelError("ResetPassword", error.Description);

        return BadRequest(ModelState);
    }

    [HttpPost("changepassword")]
    [Authorize]
    public async Task<IActionResult> ChangePassword([FromBody] PostChangePasswordDto model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await _userManager.GetUserAsync(User);

        if (user == null)
            return Unauthorized();

        var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

        if (result.Succeeded)
            return Ok("Password has been changed successfully");

        foreach (var error in result.Errors)
            ModelState.AddModelError("ChangePassword", error.Description);

        return BadRequest(ModelState);
    }
}
