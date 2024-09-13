namespace Chipsoft.Assignments.EPDApplication.Interfaces;

public interface IPhysicianService
{
    void Add(AddPhysicianDTO patientDTO);

    void Delete(int patientId);

    IEnumerable<PhysicianDTO> GetAll();
}