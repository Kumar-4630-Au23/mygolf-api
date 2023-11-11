using Mygolf.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Mygolf.Data
{

    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State Shirt", "Nike", 39.99m) { Id = 1 },
                new Item("Shorts", "Ohio State shorts", "Nike", 49.99m) { Id = 2 }
            );
        }
    }
}