namespace Chipsoft.Assignments.EPDApplication.Interfaces;

public interface IAppointmentService
{
    void Add(AddAppointmentDTO appointmentDTO);

    IEnumerable<AppointmentDTO> GetAll();
}