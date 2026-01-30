using MeteorWebApp.Models;

namespace MeteorWebApp.Services;

public class ProductService
{
    private readonly List<ProductModel> _products = new()
    {
        new ProductModel
        {
            Id = 1,
            Title = "Infinite Football",
            Description = "Infinite Football es un infinite runner ambientado...",
            ReleaseDate = new DateTime(2025, 6, 12),
            Poster = "/imgs/productInfinite/poster.jpg",
            StoreUrl = "https://play.google.com/store",
            Images =
            {
                "/imgs/productInfinite/1.jpg",
                "/imgs/productInfinite/2.jpg",
                "/imgs/productInfinite/3.jpg"
            }
        }
    };

    public ProductModel? GetById(int id)
        => _products.FirstOrDefault(p => p.Id == id);
}