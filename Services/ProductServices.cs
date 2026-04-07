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
            Description = "Face the Trials! The biggest clubs in the world have reunited to test first division players to acquire, YOU included! Show them what you've got.",
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
            Title = "MateAventuras",
            Description = "Mateaventuras need your help! Dive into their colorfull world, create your own character and help the Mateaventuras team to solve puzzles mixed with math! ",
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
        new ProductModel
        {
            Id = 3,
            Title = "The City of Fury",
            Description = "The City is corrupt with a disease, and you as a SWAT Team Leader, dive into it's streets cleaning them the only way you know.",
            ReleaseDate = new DateTime(2026, 6, 12),
            Poster = "/imgs/imgCarrusel2.png",
            StoreUrl = "/",
            Images =
            {
                "/imgs/productMateAventuras/preview_1.png",
                "/imgs/productMateAventuras/preview_2.png",
                "/imgs/productMateAventuras/preview_3.png"
            }
        },
        new ProductModel
        {
            Id = 4,
            Title = "Neighbours",
            Description = "Watch out! You moved recently to a new appartment building with a lot of charismatic neighbours, but be careful, not everything is as it seems!.",
            ReleaseDate = new DateTime(2026, 6, 12),
            Poster = "/imgs/imgCarrusel2.png",
            StoreUrl = "/",
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