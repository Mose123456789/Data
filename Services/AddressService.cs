using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class AddressService
{
    private readonly AddressRepository _addressRepository;

    public AddressService(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public AddressEntity CreateAddress(string streetName, string postalCode, string city)
    {
        var addressEntity = _addressRepository.Get(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
        addressEntity ??= _addressRepository.Create(new AddressEntity { StreetName = streetName, PostalCode = postalCode, City = city });

        return addressEntity;
    }

    public AddressEntity GetAddress(string streetName, string postalCode, string city)
    {
        var addressEntity = _addressRepository.Get(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);

        return addressEntity;
    }

    public AddressEntity GetAddressById(int Id)
    {
        var addressEntity = _addressRepository.Get(x => x.Id == Id);

        return addressEntity;
    }

    public IEnumerable<AddressEntity> GetAddresses()
    {
        var addressEntity = _addressRepository.GetAll();

        return addressEntity;
    }

    public AddressEntity UpdateAddress(AddressEntity addressEntity)
    {
        var updatedAddressEntity = _addressRepository.Update(x => x.Id == addressEntity.Id, addressEntity);

        return addressEntity;
    }

    public void DeleteAddress(int Id)
    {
        _addressRepository.Delete(x => x.Id == Id);
    }
}