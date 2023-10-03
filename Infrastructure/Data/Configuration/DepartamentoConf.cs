using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DepartamentoConf : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departartento");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder. Property (p => p.NombreDepartamento)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne (p => p.pais)
            .WithMany (p => p.Departamentos)
            .HasForeignKey(p => p.IdPais);
        }
    }
}