using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoInspectors.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoInspectors.Models
{
    public class AutoInspectorsContext : DbContext
    {
        public AutoInspectorsContext (DbContextOptions<AutoInspectorsContext> options)
            : base(options)
        {
        }

        public DbSet<AutoInspectors.Models.Vehicle> Vehicle { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inspection>()
                .HasOne(p => p.Vehicle)
                .WithMany(b => b.Inspections);
        }

        public DbSet<AutoInspectors.Models.Inspection> Inspection { get; set; }
    }
}
