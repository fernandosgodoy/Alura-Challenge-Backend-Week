using AluraFlix.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.EFPersistence.Configuration
{
    public class CategoryConfiguration
        : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categorias");

            builder.Property(v => v.Title)
                .HasColumnType("varchar(70)")
                .HasColumnName("titulo");

            builder.Property(v => v.Color)
                .HasColumnType("varchar(6)")
                .HasColumnName("cor");

        }
    }
}
