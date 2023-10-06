﻿// <auto-generated />
using System;
using Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20231005165929_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("Date");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int>("ServicioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdMascota");

                    b.HasIndex("ServicioId");

                    b.ToTable("Cita", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Ciudad", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ClienteDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Cardinal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .HasColumnType("longtext");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .HasColumnType("longtext");

                    b.Property<string>("LetraSec")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("LetraTer")
                        .HasColumnType("longtext");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeVia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudad")
                        .IsUnique();

                    b.HasIndex("IdCliente")
                        .IsUnique();

                    b.ToTable("ClienteDireccion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ClienteTelefono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("ClienteTelefono", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPais")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPais");

                    b.ToTable("Departartento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdRaza")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdRaza");

                    b.ToTable("Mascota", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Raza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRaza")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Raza", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Servicio", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Cliente")
                        .WithMany("Citas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Mascota", "Mascota")
                        .WithMany("Citas")
                        .HasForeignKey("IdMascota")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Servicio", "Servicio")
                        .WithMany("Citas")
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mascota");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.HasOne("Core.Entities.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.HasOne("Core.Entities.Ciudad", null)
                        .WithMany("Cliente")
                        .HasForeignKey("CiudadId");
                });

            modelBuilder.Entity("Core.Entities.ClienteDireccion", b =>
                {
                    b.HasOne("Core.Entities.Ciudad", "Ciudad")
                        .WithOne("ClienteDireccion")
                        .HasForeignKey("Core.Entities.ClienteDireccion", "IdCiudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Cliente", "Cliente")
                        .WithOne("ClienteDireccion")
                        .HasForeignKey("Core.Entities.ClienteDireccion", "IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Core.Entities.ClienteTelefono", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Cliente")
                        .WithMany("ClienteTelefonos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.HasOne("Core.Entities.Pais", "pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pais");
                });

            modelBuilder.Entity("Core.Entities.Mascota", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Cliente")
                        .WithMany("Mascotas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Raza", "Raza")
                        .WithMany("Mascotas")
                        .HasForeignKey("IdRaza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Raza");
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("ClienteDireccion");
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("ClienteDireccion");

                    b.Navigation("ClienteTelefonos");

                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Core.Entities.Mascota", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.Raza", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Core.Entities.Servicio", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
