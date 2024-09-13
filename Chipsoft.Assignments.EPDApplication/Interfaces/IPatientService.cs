namespace Chipsoft.Assignments.EPDApplication.Interfaces;

public interface IPatientService
{
    void Add(AddPatientDTO patientDTO);

    void Delete(int patientId);

    IEnumerable<PatientDTO> GetAll();
}