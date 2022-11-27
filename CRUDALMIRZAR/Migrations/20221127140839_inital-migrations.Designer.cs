﻿// <auto-generated />
using CRUDALMIRZAR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDALMIRZAR.Migrations
{
    [DbContext(typeof(PetDbContext))]
    [Migration("20221127140839_inital-migrations")]
    partial class initalmigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUDALMIRZAR.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetId"));

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Dono")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("PetId");

                    b.ToTable("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}