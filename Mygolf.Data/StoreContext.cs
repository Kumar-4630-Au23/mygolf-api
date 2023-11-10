﻿using Mygolf.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Mygolf.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    { }

    public DbSet<Item> Items { get; set; }
}
