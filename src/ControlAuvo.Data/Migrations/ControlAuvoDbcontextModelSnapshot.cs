﻿// <auto-generated />
using System;
using ControlAuvo.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ControlAuvo.Data.Migrations
{
    [DbContext(typeof(ControlAuvoDbcontext))]
    partial class ControlAuvoDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ControlAuvo.Business.Models.Empregado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ControlAuvo.Business.Models.Registro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("EmpregadoId")
                        .HasColumnType("uuid");

                    b.Property<int>("Tipo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmpregadoId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("ControlAuvo.Business.Models.Registro", b =>
                {
                    b.HasOne("ControlAuvo.Business.Models.Empregado", "Empregado")
                        .WithMany("Registros")
                        .HasForeignKey("EmpregadoId");
                });
#pragma warning restore 612, 618
        }
    }
}
