using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambit.Models
{
    public class MiStartupContext : DbContext
    {
        public MiStartupContext(DbContextOptions<MiStartupContext> options)
            : base(options)
        {
        }

        public DbSet<MiStartup> MiStartup { get; set; }
        public DbSet<Mi> Mi { get; set; }
        public DbSet<Startup> Startup { get; set; }
		public DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Category>().
				HasKey(c => (new { c.CategoryID }));

			modelBuilder.Entity<Startup>()
				.HasOne(s => s.Category)
				.WithMany(s => s.Startups)
				.HasForeignKey(c => c.CategoryID);

			modelBuilder.Entity<Mi>().
                HasKey(m => (new { m.RegisterNumber }));

            modelBuilder.Entity<Startup>().
                HasKey(m => (new { m.Tva }));

            modelBuilder.Entity<MiStartup>()
                .HasKey(ms => new { ms.RegisterNumber, ms.Tva });

            modelBuilder.Entity<MiStartup>()
                .HasOne(ms => ms.Mi)
                .WithMany(s => s.MiStartups)
                .HasForeignKey(ms => ms.RegisterNumber);

            modelBuilder.Entity<MiStartup>()
                .HasOne(ms => ms.Startup)
                .WithMany(s => s.MiStartups)
                .HasForeignKey(ms => ms.Tva);
        }
    }
}
