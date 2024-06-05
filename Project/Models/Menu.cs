namespace Project.Models;

public class Menu
{
    public required string Name { get; set; }

    public required Guid CompanyId { get; set; }
    
    public required Guid[] ProductIds { get; set; } = null!;
}