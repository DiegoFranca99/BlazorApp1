﻿namespace BlazorApp1.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProduct(List<CartItem> cartItems);
        Task<ServiceResponse<List<CartProductResponse>>> StoreCartItems(List<CartItem> cartItems);
        Task<ServiceResponse<int>> GetCartItemsCounts();
        Task<ServiceResponse<List<CartProductResponse>>> GetDbCartProducts(int? userId = null);
        Task<ServiceResponse<bool>> AddToCart(CartItem cartItem);
        Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem);
        Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId);
    }
}
