using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class AnunciarMapping : IEntityTypeConfiguration<Anunciar>
    {
        public void Configure(EntityTypeBuilder<Anunciar> builder)
        {
            builder.HasKey(a => a.IdAnuncio);

            builder.OwnsOne(a => a.Anunciante,c => 
            {
                c.WithOwner().HasForeignKey("IdUsuario");
                c.Property(c => c.IdUsuario);
                c.HasKey("IdUsuario");
            });

            builder.OwnsOne(a => a.Categoria, ca =>
            {
                ca.WithOwner().HasForeignKey("IdCategoria");
                ca.Property(c => c.IdCategoria);
                ca.HasKey("IdCategoria");
            });

            builder.OwnsOne(a => a.Contato, co =>
            {
                co.WithOwner().HasForeignKey("IdContato");
                co.Property(c => c.IdContato);
                co.HasKey("IdContato");
            });

            builder.Property(a => a.Descricao).IsRequired().HasColumnType("varchar(150)");
            builder.Property(a => a.Valor).IsRequired().HasColumnType("int");
            builder.Property(a => a.Titulo).IsRequired().HasColumnType("varchar(100)");

            builder.ToTable("Anunciar");
        }
    }
}




