namespace Chipsoft.Assignments.EPDConsole;

public interface IPrintService
{
    void PrintPatients(IEnumerable<PatientDTO> patients);
}