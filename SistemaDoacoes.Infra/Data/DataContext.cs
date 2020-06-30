using Microsoft.EntityFrameworkCore;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<AssistedInstitution> AssistedInstitutions { get; set; }

        public DbSet<Assisted> Assisted { get; set; }

        public DbSet<Donation> Donations { get; set; }

        public DbSet<Donor> Donors { get; set; }

        public DbSet<DonorInstitution> DonorInstitutions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssistedMap());
            modelBuilder.ApplyConfiguration(new AssistedInstitutionMap());
            modelBuilder.ApplyConfiguration(new DonationMap());
            modelBuilder.ApplyConfiguration(new DonorMap());
            modelBuilder.ApplyConfiguration(new DonorInstitutionMap());
        }


    }
}
