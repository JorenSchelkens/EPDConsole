namespace Chipsoft.Assignments.EPDApplication.Interfaces;

public interface IPatientService
{
    void AddPatient(AddPatientDTO patientDTO);

    void DeletePatient(int patientId);

    IEnumerable<PatientDTO> GetAllPatients();
}