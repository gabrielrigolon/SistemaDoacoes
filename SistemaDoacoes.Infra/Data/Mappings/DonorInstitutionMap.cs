using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Mappings
{
    public class DonorInstitutionMap : IEntityTypeConfiguration<DonorInstitution>
    {
        public void Configure(EntityTypeBuilder<DonorInstitution> builder)
        {
            builder.ToTable("TB_INSTITUICAO_DOADORA");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(x => x.Cnpj)
                .HasMaxLength(14)
                .IsRequired()
                .HasColumnName("cnpj");

            builder.Property(x => x.FantasyName)
                .IsRequired()
                .HasColumnName("nome_fantasia");

            builder.Property(x => x.CorporateName)
                .IsRequired()
                .HasColumnName("razao_social");

            builder.Property(x => x.Active)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("ativo");
        }
    }
}
