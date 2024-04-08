namespace WebApplication1;

public class Animal
{
    internal int Id { get; set; }
    private string Name { get; set; }
    private string Category { get; set; }
    private double Mass { get; set; }
    private string Colour { get; set; }


    public Animal(int id, string name, string category, double mass, string colour)
    {
        Id = id;
        Name = name;
        Category = category;
        Mass = mass;
        Colour = colour;
    }
    
    
}