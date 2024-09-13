namespace Chipsoft.Assignments.EPDApplication.Mappers;

public static class AddressMapper
{
    public static Address ToAddress(this AddressDTO addressDTO) => new()
    {
        Country = addressDTO.Country,
        City = addressDTO.City,
        PostalCode = addressDTO.PostalCode,
        StreetName = addressDTO.StreetName,
        Number = addressDTO.Number,
    };

    public static AddressDTO ToDTO(this Address address) => new(address.Country, address.City, address.PostalCode, address.StreetName, address.Number);
}