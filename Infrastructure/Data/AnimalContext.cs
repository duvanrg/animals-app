using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<ClienteDireccion> ClienteDirecciones { get; set; }
        public DbSet<ClienteTelefono> ClienteTelefonos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}