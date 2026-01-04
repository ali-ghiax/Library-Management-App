namespace MyBlazorApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public string Edition { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int TotalCopies { get; set; }
    }
}