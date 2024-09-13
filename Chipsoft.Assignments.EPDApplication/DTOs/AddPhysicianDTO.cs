namespace Chipsoft.Assignments.EPDApplication.DTOs;

public record AddPhysicianDTO(string FirstName, string LastName, DateOnly DateOfBirth, AddressDTO Address);