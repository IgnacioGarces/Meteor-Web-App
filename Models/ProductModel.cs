namespace Meteor_Web_App.Models
{
    public class ProductModel
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public required string Poster { get; set; }
        public required string? StoreUrl { get; set; }
        public List<string> Images { get; set; } = new();
        public int Id { get; internal set; }
    }
}
