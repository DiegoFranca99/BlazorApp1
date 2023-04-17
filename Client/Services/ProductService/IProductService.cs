using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
