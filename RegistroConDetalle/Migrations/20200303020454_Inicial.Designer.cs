﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroConDetalle.DAL;

namespace RegistroConDetalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200303020454_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("RegistroConDetalle.Entidades.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.TelefonosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PersonasPersonaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoTelefono")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PersonasPersonaId");

                    b.ToTable("Telefonos");
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.TelefonosDetalle", b =>
                {
                    b.HasOne("RegistroConDetalle.Entidades.Personas", null)
                        .WithMany("Telefonos")
                        .HasForeignKey("PersonasPersonaId");
                });
#pragma warning restore 612, 618
        }
    }
}
