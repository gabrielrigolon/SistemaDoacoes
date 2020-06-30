using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Mappings
{
    public class DonorMap : IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.ToTable("TB_DOADOR");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(x => x.Cpf)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("cpf");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("nome");

            builder.Property(x => x.BornDate)
                .IsRequired()
                .HasColumnName("data_nascimennto");

            builder.Property(x => x.Schooling)
                .IsRequired()
                .HasColumnName("escolaridade");

            builder.Property(x => x.Active)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("ativo");
        }
    }
}
