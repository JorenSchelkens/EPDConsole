namespace Chipsoft.Assignments.EPDApplication.Interfaces;

public interface IPhysicianService
{
    void Add(AddPhysicianDTO physicianDTO);

    void Delete(int physicianId);

    IEnumerable<PhysicianDTO> GetAll();
}