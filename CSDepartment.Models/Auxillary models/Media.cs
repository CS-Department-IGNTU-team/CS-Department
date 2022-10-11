namespace CSDepartment.Models
{
    public class Media
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public MediaType Type { get; set; }

        public string? Description { get; set; }
    }

    public enum MediaType
    {
        IMAGE,
        VIDEO,
    }
}