using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Mappings
{
    public class AssistedInstitutionMap : IEntityTypeConfiguration<AssistedInstitution>
    {
        public void Configure(EntityTypeBuilder<AssistedInstitution> builder)
        {
            builder.ToTable("TB_INSTITUICAO_ASSISTIDA");

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

            builder.Property(x => x.QtdAssisted)
                .IsRequired()
                .HasColumnName("qtd_assistidos");

            builder.Property(x => x.InstitutionType)
                .IsRequired()
                .HasColumnName("tipo_instituicao");

            builder.Property(x => x.Active)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("ativo");
        }
    }
}
