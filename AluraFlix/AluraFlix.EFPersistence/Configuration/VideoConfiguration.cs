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
    internal class VideoConfiguration
        : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable("videos");

            builder.Property(v => v.Title)
                .HasColumnType("varchar(70)")
                .HasColumnName("titulo");

            builder.Property(v => v.Description)
                .HasColumnType("varchar(400)")
                .HasColumnName("descricao");

            builder.Property(v => v.Url)
                .HasColumnType("varchar(70)")
                .HasColumnName("url");

        }
    }
}
