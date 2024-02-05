using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

public class RoleRepository : Repository<RoleEntity>
{
    public RoleRepository(DataContext context) : base(context)
    {

    }
}