namespace Chipsoft.Assignments.EPDConsole;

public class InputService(IPrintService printService) : IInputService
{
    private readonly IPrintService _printService = printService;

    public AddPatientDTO ReadPatientDTO()
    {
        var firstName = InputHelper.ReadString("Voornaam");
        var lastName = InputHelper.ReadString("Achternaam");
        var nationalRegistryNumber = InputHelper.ReadString("Rijksregisternummer");
        var email = InputHelper.ReadString("Email");
        var phoneNumber = InputHelper.ReadString("Telefoonnummer");
        var dateOfBirth = InputHelper.ReadDateOnly("Geboortedatum");
        var addressDTO = ReadAddress();

        return new AddPatientDTO(firstName, lastName, nationalRegistryNumber, email, phoneNumber, dateOfBirth, addressDTO);
    }

    public AddPhysicianDTO ReadPhysicianDTO()
    {
        var firstName = InputHelper.ReadString("Voornaam");
        var lastName = InputHelper.ReadString("Achternaam");
        var dateOfBirth = InputHelper.ReadDateOnly("Geboortedatum");
        var addressDTO = ReadAddress();

        return new AddPhysicianDTO(firstName, lastName, dateOfBirth, addressDTO);
    }

    public AddAppointmentDTO ReadAppointmentDTO(IEnumerable<PatientDTO> patients, IEnumerable<PhysicianDTO> physicians)
    {
        _printService.PrintPatients(patients);
        var patientId = InputHelper.ReadInt("Patiënt Id");

        _printService.PrintPhysicians(physicians);
        var physicianId = InputHelper.ReadInt("Arts Id");

        var dateAndTime = InputHelper.ReadDateTime("Datum en tijd van afspraak");

        return new AddAppointmentDTO(patientId, physicianId, dateAndTime);
    }

    private static AddressDTO ReadAddress()
    {
        var country = InputHelper.ReadString("Land");
        var city = InputHelper.ReadString("Stad");
        var postalCode = InputHelper.ReadString("Postcode");
        var streetName = InputHelper.ReadString("Straat");
        var number = InputHelper.ReadString("Nummer");

        return new AddressDTO(country, city, postalCode, streetName, number);
    }
}