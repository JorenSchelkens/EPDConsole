namespace Chipsoft.Assignments.EPDConsole;

public class InputService : IInputService
{
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