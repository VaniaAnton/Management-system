namespace Project.Models;

public class Table
{
    public required string Name { get; set; }

    public required Guid CompanyId { get; set; }
    
    public int NumberOfPeople { get; set; }
}