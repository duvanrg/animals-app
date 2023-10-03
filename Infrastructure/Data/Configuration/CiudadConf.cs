using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class Configuration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudad");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder. Property (p => p.NombreCiudad)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.HasOne (p => p.Departamento)
            .WithMany (p => p.Ciudades)
            .HasForeignKey(p => p.IdDepartamento);
        }
    }
}