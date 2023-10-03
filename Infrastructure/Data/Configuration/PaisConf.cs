using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PaisConf : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property (p => p.NombrePais)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}