using ASP.NET_API.Dtos;
using ASP.NET_API.Model;
using AutoMapper;

namespace ASP.NET_API.Services;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ProductCategory, GetProductCategoryDto>();
        CreateMap<PostProductCategoryDto, ProductCategory>();

        CreateMap<Product, GetProductDto>();
        CreateMap<PostProductDto, Product>();

        CreateMap<PostSignUpDto, AppUser>();
        CreateMap<PostRefreshTokenDto, RefreshToken>();

        CreateMap<AppUser, GetAppUserDto>().ForMember(x => x.UserId, opt => opt.MapFrom(y => y.Id));

        CreateMap<OrderItem, GetOrderItemDto>();
        CreateMap<PostOrderItemDto, OrderItem>();
        CreateMap<PutOrderItemDto, OrderItem>();

        CreateMap<Order, GetOrderDto>();
        CreateMap<PostOrderDto, Order>();
        CreateMap<PutOrderDto, Order>();

        CreateMap<ShoppingCart, GetShoppingCartDto>();
        CreateMap<PostShoppingCartDto, ShoppingCart>();
        CreateMap<PutShoppingCartDto, ShoppingCart>();

        CreateMap<CartItem, GetCartItemDto>();
        CreateMap<PostCartItemDto, CartItem>();
        CreateMap<PutCartItemDto, CartItem>();

        CreateMap<WishListItem, GetWishListItemDto>();

        CreateMap<WishList, GetWishListDto>();

        CreateMap<Review, GetReviewDto>();
        CreateMap<PostReviewDto, Review>();
        CreateMap<PutReviewDto, Review>();

        CreateMap<Promotion, GetPromotionDto>();
        CreateMap<PostPromotionDto, Promotion>();
        CreateMap<PutPromotionDto, Promotion>();
    }
}