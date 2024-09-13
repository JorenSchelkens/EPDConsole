namespace Chipsoft.Assignments.EPDApplication.Services;

public class PatientService(EPDDbContext dbContext) : IPatientService
{
    private readonly EPDDbContext _dbContext = dbContext;

    public void AddPatient(AddPatientDTO patientDTO)
    {
        var patient = patientDTO.ToPatient();

        _dbContext.Patients.Add(patient);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(AddPatient));
        }
    }

    public void DeletePatient(int patientId)
    {
        var patient = _dbContext.Patients.FirstOrDefault(v => v.Id == patientId)
            ?? throw new NotFoundException(patientId, nameof(DeletePatient));

        _dbContext.Patients.Remove(patient);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(DeletePatient));
        }
    }

    public IEnumerable<PatientDTO> GetAllPatients() => _dbContext.Patients.Select(v => v.ToDTO()).ToArray();
}