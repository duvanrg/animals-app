using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CitaConf : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder.ToTable("Cita");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder. Property (p => p.Fecha)
            .HasColumnType("Date");
            builder. Property (p => p.Hora)
            .HasColumnType("time");

            builder.HasOne(p => p.Cliente)
            .WithMany (p => p.Citas)
            .HasForeignKey(p => p.IdCliente);

            builder.HasOne (p => p.Mascota)
            .WithMany (p => p.Citas)
            .HasForeignKey(p => p.IdMascota);

            builder.HasOne (p => p.Servicio)
            .WithMany (p => p.Citas)
            .HasForeignKey(p => p.ServicioId);
        }
    }
}