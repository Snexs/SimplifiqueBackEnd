using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.IdContato);

            builder.OwnsOne(c => c.IdUsuario, cto =>
            {
                cto.WithOwner().HasForeignKey("IdUsuario");
                cto.Property(c => c.IdUsuario).IsRequired();
                cto.HasKey("IdUsuario");
            });

            builder.Property(c => c.Facebook).HasColumnType("varchar(100)");
            builder.Property(c => c.Instagram).HasColumnType("varchar(100)");
            builder.Property(c => c.Telefone).HasColumnType("bigint");
            builder.Property(c => c.WhatsApp).HasColumnType("bigint");
            builder.Property(c => c.Email).HasColumnType("varchar(100)");

            builder.ToTable("Contato");

        }
    }
}