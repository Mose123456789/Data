using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class CustomerService
{
    private readonly CustomerRepository _customerRepository;
    private readonly AddressService _addressService;
    private readonly RoleService _roleService;

    public CustomerService(CustomerRepository customerRepository, AddressService addressService, RoleService roleService)
    {
        _customerRepository = customerRepository;
        _addressService = addressService;
        _roleService = roleService;
    }

    public CustomerEntity CreateCustomer(string firstName, string lastName, string email, string roleName, string streetName, string postalCode, string city)
    {
        var roleEntity = _roleService.CreateRole(roleName);
        var addressEntity = _addressService.CreateAddress(streetName, postalCode, city);

        var customerEntity = new CustomerEntity
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            RoleId = roleEntity.Id,
            Address = addressEntity,
        };

        customerEntity = _customerRepository.Create(customerEntity);

        return customerEntity;
    }

    public CustomerEntity GetCustomerByEmail(string email)
    {
        var customerEntity = _customerRepository.Get(x => x.Email == email);

        return customerEntity;
    }

    public CustomerEntity GetCustomerById(int Id)
    {
        var customerEntity = _customerRepository.Get(x => x.Id == Id);

        return customerEntity;
    }

    public IEnumerable<CustomerEntity> GetCustomers()
    {
        var customers = _customerRepository.GetAll();

        return customers;
    }

    public CustomerEntity UpdateCustomer(CustomerEntity customerEntity)
    {
        var updatedcustomerEntity = _customerRepository.Update(x => x.Id == customerEntity.Id, customerEntity);

        return customerEntity;
    }

    public void DeleteCustomer(int Id)
    {
        _customerRepository.Delete(x => x.Id == Id);
    }
}