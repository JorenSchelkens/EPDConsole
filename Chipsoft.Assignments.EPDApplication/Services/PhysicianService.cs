namespace Chipsoft.Assignments.EPDApplication.Services;

public class PhysicianService(EPDDbContext dbContext) : IPhysicianService
{
    private readonly EPDDbContext _dbContext = dbContext;

    public void Add(AddPhysicianDTO patientDTO)
    {
        var patient = patientDTO.ToPhysician();

        _dbContext.Physicians.Add(patient);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(Add));
        }
    }

    public void Delete(int patientId)
    {
        var patient = _dbContext.Physicians.FirstOrDefault(v => v.Id == patientId)
            ?? throw new NotFoundException(patientId, nameof(Delete));

        _dbContext.Physicians.Remove(patient);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(Delete));
        }
    }

    public IEnumerable<PhysicianDTO> GetAll() => _dbContext.Physicians.Select(v => v.ToDTO()).ToArray();
}