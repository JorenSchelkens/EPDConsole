namespace Chipsoft.Assignments.EPDConsole.Interfaces;

public interface IInputService
{
    AddPatientDTO ReadPatientDTO();
    AddPhysicianDTO ReadPhysicianDTO();
    AddAppointmentDTO ReadAppointmentDTO(IEnumerable<PatientDTO> patients, IEnumerable<PhysicianDTO> physicians);
}