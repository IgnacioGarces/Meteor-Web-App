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
            Poster = "/imgs/productInfinite/poster.png",
            StoreUrl = "https://play.google.com/store",
            Images =
            {
                "/imgs/productInfinite/preview_1.png",
                "/imgs/productInfinite/preview_2.png",
                "/imgs/productInfinite/preview_3.png",

            }
        },
        new ProductModel
        {
            Id = 2,
            Title = "TROT",
            Description = "TROT es un infinite runner ambientado...",
            ReleaseDate = new DateTime(2026, 6, 12),
            Poster = "/imgs/imgCarrusel2.png",
            StoreUrl = "/game",
            Images =
            {
                "/imgs/productMateAventuras/preview_1.png",
                "/imgs/productMateAventuras/preview_2.png",
                "/imgs/productMateAventuras/preview_3.png"
            }
        },
        
    };

    public ProductModel? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    public IEnumerable<ProductModel> GetAll() => _products;
}