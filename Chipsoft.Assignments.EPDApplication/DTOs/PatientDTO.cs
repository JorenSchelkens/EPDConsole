namespace Chipsoft.Assignments.EPDApplication.DTOs;

public record PatientDTO(int Id, string FirstName, string LastName, string NationalRegistryNumber, string Email, string PhoneNumber, DateOnly DateOfBirth, AddressDTO Address)
{
    public string FullName => $"{this.FirstName} {this.LastName}";
}