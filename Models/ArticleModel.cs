namespace MeteorWebApp.Models
{
    public class ArticleModel
    {
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string StoreUrl { get; set; }
        public int Id { get; internal set; }
    }
}