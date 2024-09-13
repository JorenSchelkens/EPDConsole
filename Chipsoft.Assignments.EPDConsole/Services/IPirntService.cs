namespace Chipsoft.Assignments.EPDConsole;

public interface IPrintService
{
    void PrintPatients(IEnumerable<PatientDTO> patients);

    void PrintPhysicians(IEnumerable<PhysicianDTO> physicians);

    void PrintAppointments(IEnumerable<AppointmentDTO> appointments);
}