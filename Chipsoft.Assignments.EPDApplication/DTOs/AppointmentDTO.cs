namespace Chipsoft.Assignments.EPDApplication.DTOs;

public record AppointmentDTO(PatientDTO Patient, PhysicianDTO Physician, DateTime DateAndTime);