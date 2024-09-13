namespace Chipsoft.Assignments.EPDApplication.Mappers;

public static class PhysicianMapper
{
    public static Physician ToPhysician(this AddPhysicianDTO physicianDTO) => new()
    {
        FirstName = physicianDTO.FirstName,
        LastName = physicianDTO.LastName,
        DateOfBirth = physicianDTO.DateOfBirth,
        Address = physicianDTO.Address.ToAddress()
    };

    public static PhysicianDTO ToDTO(this Physician physician) => new(physician.Id, physician.FirstName, physician.LastName, physician.DateOfBirth, physician.Address.ToDTO());
}