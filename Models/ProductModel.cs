namespace MeteorWebApp.Models
{
    public class ProductModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }
        public string StoreUrl { get; set; }
        public List<string> Images { get; set; } = new();
        public int Id { get; internal set; }
    }
}
