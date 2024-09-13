namespace Chipsoft.Assignments.EPDConsole;

public interface IInputService
{
    AddPatientDTO ReadPatientDTO();
    AddPhysicianDTO ReadPhysicianDTO();
    AddAppointmentDTO ReadAppointmentDTO(IEnumerable<PatientDTO> patients, IEnumerable<PhysicianDTO> physicians);
}