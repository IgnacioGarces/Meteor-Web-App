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
                "/imgs/productInfinite/preview_1.png",
                "/imgs/productInfinite/preview_2.png",
                "/imgs/productInfinite/preview_3.png"
            }
        }
    };

    public ProductModel? GetById(int id)
        => _products.FirstOrDefault(p => p.Id == id);
}