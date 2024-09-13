namespace Chipsoft.Assignments.EPDApplication.Models;

public class Patient
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NationalRegistryNumber { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required Address Address { get; set; }

    public int AddressId { get; set; }
}
