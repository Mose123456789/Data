using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

public class CustomerRepository : Repository<CustomerEntity>
{
    public CustomerRepository(DataContext context) : base(context)
    {

    }
}