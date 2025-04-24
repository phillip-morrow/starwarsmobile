namespace StarWarsMobile.Models
{
    public class DetailsModel
    {
        public string Title { get; set; } = string.Empty; // Common title (e.g., name or movie title)
        public string Description { get; set; } = string.Empty; // Detailed description
        public Dictionary<string, string> AdditionalInfo { get; set; } = new(); // Key-value pairs for extra details
    }
}