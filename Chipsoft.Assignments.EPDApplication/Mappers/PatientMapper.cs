namespace Chipsoft.Assignments.EPDApplication.Mappers;

public static class PatientMapper
{
    public static Patient ToPatient(this AddPatientDTO patientDTO) => new()
    {
        FirstName = patientDTO.FirstName,
        LastName = patientDTO.LastName,
        NationalRegistryNumber = patientDTO.NationalRegistryNumber,
        Email = patientDTO.Email,
        PhoneNumber = patientDTO.PhoneNumber,
        DateOfBirth = patientDTO.DateOfBirth,
        Address = patientDTO.Address.ToAddress()
    };

    public static PatientDTO ToDTO(this Patient patient) => new(patient.Id, patient.FirstName, patient.LastName, patient.NationalRegistryNumber, patient.Email, patient.PhoneNumber, patient.DateOfBirth, patient.Address.ToDTO());
}