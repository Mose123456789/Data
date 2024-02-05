using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

public class AddressRepository : Repository<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {

    }
}