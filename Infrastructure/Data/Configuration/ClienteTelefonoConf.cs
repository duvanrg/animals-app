using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ClienteTelefonoConf : IEntityTypeConfiguration<ClienteTelefono>
    {
        public void Configure(EntityTypeBuilder<ClienteTelefono> builder)
        {
            builder.ToTable("ClienteTelefono");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property (p => p.Numero)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne (p => p.Cliente)
            .WithMany (p => p.ClienteTelefonos)
            .HasForeignKey(p => p.IdCliente);
        }
    }
}