namespace Project.Models;

public class Menu
{
    public required string Name { get; set; }

    public Guid CompanyId { get; set; }
    
    public Guid ProductIds { get; set; }
    
}