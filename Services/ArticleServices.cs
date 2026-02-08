using MeteorWebApp.Models;

namespace MeteorWebApp.Services;

public class ArticleService
{
    private readonly List<ArticleModel> _articles = new()
    {
        new ArticleModel
        {
            Id = 1,
            Date = new DateTime(2025, 6, 12),
            ImageUrl = "/imgs/productInfinite/poster.png",
            Title = "Infinite Football",
            Content = "Infinite Football es un infinite runner ambientado...Infinite Football es un infinite runner ambientado...Infinite Football es un infinite runner ambientado...Infinite Football es un infinite runner ambientado...Infinite Football es un infinite runner ambientado...Infinite Football es un infinite runner ambientado...Infinite Football es un infinite runner ambientado...",
            StoreUrl = "https://play.google.com/store",
            
        },
       

    };

    public ArticleModel? GetById(int id)
        => _articles.FirstOrDefault(p => p.Id == id);
}