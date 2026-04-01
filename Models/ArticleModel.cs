namespace MeteorWebApp.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public required string Title { get; set; }
        
        // Bloque de Introducción (Opcional)
        public string? FirstImageUrl { get; set; }
        public string? FirstSubtitle { get; set; }
        public string? Description { get; set; }
        public string? SecondDescription { get; set; }

        
        // Secciones Dinámicas (Intercaladas)
        public string[] ImageUrl { get; set; } = Array.Empty<string>();
        public string[]? SectionTitles { get; set; }
        public string[] Content { get; set; } = Array.Empty<string>();
        
        public required string StoreUrl { get; set; }
    }
}