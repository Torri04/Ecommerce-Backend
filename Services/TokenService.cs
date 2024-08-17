using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ASP.NET_API.Services
{
    public class TokenService : ITokenService
    {
        private readonly MyDbContext _context;
        private readonly IConfiguration _config;
        private SymmetricSecurityKey _key;
        public IMapper _mapper;
        public TokenService(IConfiguration config, MyDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _config = config;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SigningKey"]));
        }
        public string CreateToken(AppUser user, string role)
        {
            //JSON: Header(creds).Payload(claims).Signature(creds)

            //Claims for authentication (Payload)
            var claims = new List<Claim>() {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, role),
             };

            //SigningCredentials (creds)
            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),

                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = creds,
                Issuer = _config.GetSection("JWT")["Issuer"],
                Audience = _config.GetSection("JWT")["Audience"],
            };

            var tokenHandle = new JwtSecurityTokenHandler();

            var token = tokenHandle.CreateToken(tokenDescriptor);

            return tokenHandle.WriteToken(token);
        }
        public async Task<RefreshToken?> CreateRefreshTokenAsync(AppUser user)
        {
            var postRefreshTokenDto = new PostRefreshTokenDto(user.Id);

            var refreshToken = _mapper.Map<RefreshToken>(postRefreshTokenDto);

            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();

            return refreshToken;
        }
        public async Task<RefreshToken?> GetRefreshTokenAsync(AppUser user)
        {
            return await _context.RefreshTokens.FirstOrDefaultAsync(x => x.UserId == user.Id);
        }
        public async Task<RefreshToken?> UpdateRefreshTokenAsync(AppUser user)
        {
            var putTokenDto = new PutRefreshTokenDto();

            var token = await _context.RefreshTokens.FirstOrDefaultAsync(p => p.UserId == user.Id);

            if (token == null)
                return null;
            else
            {
                _context.Entry(token).CurrentValues.SetValues(putTokenDto);
                await _context.SaveChangesAsync();
                return token;
            }
        }

        public async Task<bool> IsRefreshTokenExpiriedAsync(AppUser user)
        {
            var token = await _context.RefreshTokens.FirstOrDefaultAsync(x => x.UserId == user.Id);

            if (token != null && token.ExpiriedDate < DateTime.UtcNow)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> IsRefreshTokenExistAsync(AppUser user)
        {
            return await _context.RefreshTokens.AnyAsync(x => x.UserId == user.Id);
        }
    }
}