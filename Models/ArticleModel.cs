namespace MeteorWebApp.Models
{
    public class ArticleModel
    {
        public DateTime Date { get; set; }
        public required string ImageUrl { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string StoreUrl { get; set; }
        public int Id { get; internal set; }
    }
}