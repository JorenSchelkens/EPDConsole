namespace Chipsoft.Assignments.EPDApplication.Services;

public class AppointmentService(EPDDbContext dbContext) : IAppointmentService
{
    private readonly EPDDbContext _dbContext = dbContext;

    public void Add(AddAppointmentDTO appointmentDTO)
    {
        var patient = _dbContext.Patients.FirstOrDefault(v => v.Id == appointmentDTO.PatientId)
            ?? throw new NotFoundException(appointmentDTO.PatientId, nameof(Add));

        var physician = _dbContext.Physicians.FirstOrDefault(v => v.Id == appointmentDTO.PhysicianId)
            ?? throw new NotFoundException(appointmentDTO.PhysicianId, nameof(Add));

        if (!IsPatientAvailable(patient, appointmentDTO.DateAndTime))
        {
            throw new AppointmentOverlapException($"{patient.FirstName} {patient.LastName}");
        }

        if (!IsPhysicianAvailable(physician, appointmentDTO.DateAndTime))
        {
            throw new AppointmentOverlapException($"{physician.FirstName} {physician.LastName}");
        }

        if (appointmentDTO.DateAndTime < DateTime.Now)
        {
            throw new AppointmentDateAndTimeException(appointmentDTO.DateAndTime);
        }

        var appointment = new Appointment()
        {
            Patient = patient,
            Physician = physician,
            DateAndTime = appointmentDTO.DateAndTime,
        };

        _dbContext.Appointments.Add(appointment);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(Add));
        }
    }

    public IEnumerable<AppointmentDTO> GetAll() => _dbContext.Appointments.Select(v => v.ToDTO()).ToArray();

    private bool IsPatientAvailable(Patient patient, DateTime appointmentDateAndTime)
        => !_dbContext.Appointments.Any(v => v.Patient == patient && v.DateAndTime == appointmentDateAndTime);

    private bool IsPhysicianAvailable(Physician physician, DateTime appointmentDateAndTime)
        => !_dbContext.Appointments.Any(v => v.Physician == physician && v.DateAndTime == appointmentDateAndTime);
}