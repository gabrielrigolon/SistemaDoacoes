using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Mappings
{
    public class DonationMap : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("TB_DOACAO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(x => x.Type)
                .IsRequired()
                .HasColumnName("tipo");

            builder.Property(x => x.Value)
                .IsRequired()
                .HasColumnName("valor");

            builder.Property(x => x.Active)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("ativo");

            builder.Property(x => x.IdOrigin)
                .IsRequired()
                .HasColumnName("id_origem");

            builder.Property(x => x.IdDestination)
                .IsRequired()
                .HasColumnName("id_destino");


            builder.HasOne(e => e.Assisted)
                .WithMany(d => d.Donations)
                .HasForeignKey(e => e.IdDestination)
                .IsRequired();

            builder.HasOne(e => e.AssistedInstitution)
               .WithMany(d => d.Donations)
               .HasForeignKey(e => e.IdDestination)
               .IsRequired();


            builder.HasOne(e => e.Donor)
                .WithMany(d => d.Donations)
                .HasForeignKey(e => e.IdOrigin)
                .IsRequired();

            builder.HasOne(e => e.DonorInstitution)
               .WithMany(d => d.Donations)
               .HasForeignKey(e => e.IdOrigin)
               .IsRequired();

        }
    }
}
