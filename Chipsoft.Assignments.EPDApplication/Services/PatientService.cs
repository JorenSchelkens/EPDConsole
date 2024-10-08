﻿namespace Chipsoft.Assignments.EPDApplication.Services;

public class PatientService(EPDDbContext dbContext) : IPatientService
{
    private readonly EPDDbContext _dbContext = dbContext;

    public void Add(AddPatientDTO patientDTO)
    {
        var patient = patientDTO.ToPatient();

        _dbContext.Patients.Add(patient);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(Add));
        }
    }

    public void Delete(int patientId)
    {
        var patient = _dbContext.Patients.FirstOrDefault(v => v.Id == patientId)
            ?? throw new NotFoundException(patientId, nameof(Delete));

        _dbContext.Patients.Remove(patient);
        var result = _dbContext.SaveChanges();

        if (result < 1)
        {
            throw new DatabaseException(nameof(Delete));
        }
    }

    public IEnumerable<PatientDTO> GetAll() => _dbContext.Patients.Select(v => v.ToDTO()).ToArray();
}