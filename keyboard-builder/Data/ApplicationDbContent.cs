using System;
using System.Collections.Generic;
using keyboard_builder.Models;
using Microsoft.EntityFrameworkCore;
namespace keyboard_builder.Data

{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<KeyboardOrder> KeyboardOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}

