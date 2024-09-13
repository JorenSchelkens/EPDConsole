namespace Chipsoft.Assignments.EPDApplication.Mappers;

public static class AppointmentMapper
{
    public static AppointmentDTO ToDTO(this Appointment appointment) => new(appointment.Patient.ToDTO(), appointment.Physician.ToDTO(), appointment.DateAndTime);
}