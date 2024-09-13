namespace Chipsoft.Assignments.EPDConsole;

public class PrintService : IPrintService
{
    public void PrintPatients(IEnumerable<PatientDTO> patients)
    {
        Console.WriteLine();
        foreach (PatientDTO patient in patients)
        {
            Console.WriteLine($"{patient.Id}: {patient.FirstName} {patient.LastName}");
        }
        Console.WriteLine();
    }

    public void PrintPhysicians(IEnumerable<PhysicianDTO> physicians)
    {
        Console.WriteLine();
        foreach (PhysicianDTO physician in physicians)
        {
            Console.WriteLine($"{physician.Id}: {physician.FirstName} {physician.LastName}");
        }
        Console.WriteLine();
    }
}