using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

public class CategoryRepository : Repository<CategoryEntity>
{
    public CategoryRepository(DataContext context) : base(context)
    {

    }
}