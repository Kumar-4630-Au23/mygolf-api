using Mygolf.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Mygolf.Domain.Orders;

namespace Mygolf.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    { }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        DbInitializer.Initialize(modelBuilder);
    }

}

