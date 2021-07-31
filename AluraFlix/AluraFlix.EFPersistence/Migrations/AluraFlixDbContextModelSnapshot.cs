﻿// <auto-generated />
using AluraFlix.EFPersistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AluraFlix.EFPersistence.Migrations
{
    [DbContext(typeof(AluraFlixDbContext))]
    partial class AluraFlixDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AluraFlix.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("varchar(6)")
                        .HasColumnName("cor");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(70)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("AluraFlix.Domain.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(400)")
                        .HasColumnName("descricao");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(70)")
                        .HasColumnName("titulo");

                    b.Property<string>("Url")
                        .HasColumnType("varchar(70)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("videos");
                });
#pragma warning restore 612, 618
        }
    }
}
