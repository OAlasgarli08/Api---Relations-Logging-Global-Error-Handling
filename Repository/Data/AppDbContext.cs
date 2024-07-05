﻿using Domain.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    { 
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

      public DbSet<Country> Countries { get; set; }
      public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
