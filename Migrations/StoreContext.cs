using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    public class StoreContext : DbContext
    {
        private readonly IConfiguration _config;
        public StoreContext(DbContextOptions<StoreContext> options , IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<ExperienceInformation> ExperienceInformations { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Cv> Cvs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@_config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExperienceInformation>().Property(p => p.CompanyName).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<PersonalInformation>().Property(p => p.FullName).IsRequired();
            modelBuilder.Entity<PersonalInformation>().Property(p => p.Email);
            modelBuilder.Entity<PersonalInformation>().Property(p => p.MobileNumbers).IsRequired();
            modelBuilder.Entity<Cv>().Property(p => p.Name).IsRequired();
        }

    }
}
