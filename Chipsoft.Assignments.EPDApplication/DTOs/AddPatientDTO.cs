namespace Chipsoft.Assignments.EPDApplication.DTOs;

public record AddPatientDTO(string FirstName, string LastName, string NationalRegistryNumber, string Email, string PhoneNumber, DateOnly DateOfBirth, AddressDTO Address);