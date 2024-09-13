namespace Chipsoft.Assignments.EPDApplication.Models;

public class Physician
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required Address Address { get; set; }

    public int AddressId { get; set; }

    public string FullName => $"{this.FirstName} {this.LastName}";
}
