namespace Chipsoft.Assignments.EPDConsole;

public class PrintService : IPrintService
{
    public void PrintPatients(IEnumerable<PatientDTO> patients)
    {
        Console.WriteLine();
        foreach (PatientDTO patient in patients)
        {
            Console.WriteLine($"{patient.Id}: {patient.FullName}");
        }
    }

    public void PrintPhysicians(IEnumerable<PhysicianDTO> physicians)
    {
        Console.WriteLine();
        foreach (PhysicianDTO physician in physicians)
        {
            Console.WriteLine($"{physician.Id}: {physician.FullName}");
        }
    }

    public void PrintAppointments(IEnumerable<AppointmentDTO> appointments)
    {
        Console.WriteLine();
        foreach (AppointmentDTO appointment in appointments)
        {
            var dateTimeFormatted = appointment.DateAndTime.ToString("dd/MM/yyyy HH:mm");
            Console.WriteLine($"Afspraak om {dateTimeFormatted} tussen {appointment.Patient.FullName} en {appointment.Physician.FullName}");
        }
    }
}