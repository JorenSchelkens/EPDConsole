namespace Chipsoft.Assignments.EPDApplication.Models;

public class Appointment
{
    public int Id { get; set; }
    public required Patient Patient { get; set; }
    public required Physician Physician { get; set; }
    public required DateTime DateAndTime { get; set; }

    public int PatientId { get; set; }
    public int PhysicianId { get; set; }
}
