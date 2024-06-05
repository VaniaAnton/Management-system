namespace Project.Models;

public class Product
{
    public required string Name { get; set; }

    public required Guid Id { get; set; }
    
    public required decimal Price { get; set; }
    
    public required string Currency { get; set; }
    
    public required string Category { get; set; }
}