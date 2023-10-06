using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MascotaConf : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder)
        {
            builder.ToTable("Mascota");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property (p => p.FechaNacimiento)
            .HasColumnType("datetime");

            builder.HasOne (p => p.Raza)
            .WithMany (p => p.Mascotas)
            .HasForeignKey(p => p.IdRaza);
            
            builder.HasOne (p => p.Cliente)
            .WithMany (p => p.Mascotas)
            .HasForeignKey(p => p.IdCliente);
        }
    }
}