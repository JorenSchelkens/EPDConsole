namespace Chipsoft.Assignments.EPDApplication.DTOs;

public record PhysicianDTO(int Id, string FirstName, string LastName, DateOnly DateOfBirth, AddressDTO Address);