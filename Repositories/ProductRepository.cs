using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

public class ProductRepository : Repository<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {

    }
}