using Meteor_Web_App.Models;

namespace Meteor_Web_App.Services;

public class ProductService
{
    private readonly List<ProductModel> _products = new()
    {
        new ProductModel
        {
            Id = 1,
            Title = "Infinite Football",
            Description = "Face the Trials! The biggest clubs in the world have reunited to test first division players to acquire, YOU included! Show them what you've got.",
            ReleaseDate = new DateTime(2026, 6, 12),
            Poster = "/imgs/Products/InfiniteFootball/poster.png",
            StoreUrl = null,
            Images =
            {
                "/imgs/Products/InfiniteFootball/preview_1.png",
                "/imgs/Products/InfiniteFootball/preview_2.png",
                "/imgs/Products/InfiniteFootball/preview_3.png",
            }
        },
        new ProductModel
        {
            Id = 2,
            Title = "MateAventuras",
            Description = "Mateaventuras need your help! Dive into their colorfull world, create your own character and help the Mateaventuras team to solve puzzles mixed with math! ",
            ReleaseDate = null,
            Poster = "/imgs/Products/MateAventuras/poster.png",
            StoreUrl = "/game",
            Images =
            {
                "/imgs/Products/MateAventuras/preview_1.png",
                "/imgs/Products/MateAventuras/preview_2.png",
                "/imgs/Products/MateAventuras/preview_3.png"
            }
        },
        new ProductModel
        {
            Id = 3,
            Title = "The City of Fury",
            Description = "The City is corrupt with a disease, and you as a SWAT Team Leader, dive into it's streets cleaning them the only way you know.",
            ReleaseDate = null,
            Poster = "/imgs/Products/CityOfFury/poster.png",
            StoreUrl = "https://store.steampowered.com/app/2385660/The_City_of_Fury/",
            Images =
            {
                "/imgs/Products/CityOfFury/preview_1.png",
                "/imgs/Products/CityOfFury/preview_2.png",
                "/imgs/Products/CityOfFury/preview_3.png"

            }
        },
        new ProductModel
        {
            Id = 4,
            Title = "Neighbours",
            Description = "Watch out! You moved recently to a new appartment building with a lot of charismatic neighbours, but be careful, not everything is as it seems!.",
            ReleaseDate = null,
            Poster = "/imgs/Products/Neighbors/poster.png",
            StoreUrl = "https://store.steampowered.com/app/3030680/Neighbors/",
            Images =
            {
                "/imgs/Products/Neighbors/preview_1.png",
                "/imgs/Products/Neighbors/preview_2.png",
                "/imgs/Products/Neighbors/preview_3.png"

            }
        },
        
    };

    public ProductModel? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    public IEnumerable<ProductModel> GetAll() => _products;
}