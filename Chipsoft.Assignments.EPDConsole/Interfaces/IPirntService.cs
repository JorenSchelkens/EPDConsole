namespace Chipsoft.Assignments.EPDConsole.Interfaces;

public interface IPrintService
{
    void PrintPatients(IEnumerable<PatientDTO> patients);

    void PrintPhysicians(IEnumerable<PhysicianDTO> physicians);

    void PrintAppointments(IEnumerable<AppointmentDTO> appointments);
}