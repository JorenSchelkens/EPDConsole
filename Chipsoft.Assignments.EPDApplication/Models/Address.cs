namespace Chipsoft.Assignments.EPDApplication.Models;

public class Address
{
    public int Id { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string StreetName { get; set; }
    public required string Number { get; set; }
}
