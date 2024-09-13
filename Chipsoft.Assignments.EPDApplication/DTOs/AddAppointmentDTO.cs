namespace Chipsoft.Assignments.EPDApplication.DTOs;

public record AddAppointmentDTO(int PatientId, int PhysicianId, DateTime DateAndTime);