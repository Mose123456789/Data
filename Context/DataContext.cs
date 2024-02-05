using ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConsoleApp.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }

    public DbSet<CategoryEntity> Categories { get; set; }

    public DbSet<CustomerEntity> Customers { get; set; }

    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<RoleEntity> Roles { get; set; }
}