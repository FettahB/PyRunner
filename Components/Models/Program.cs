namespace BlazorApp1.Components.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        
        public Program(int id, string name, string? description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
