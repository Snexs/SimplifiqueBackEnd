using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class AnunciarMapping : IEntityTypeConfiguration<Anunciar>
    {
        public void Configure(EntityTypeBuilder<Anunciar> builder)
        {
            builder.HasKey(a => a.Id).HasName("IdAnuncio");

            builder.OwnsOne(a => a.Anunciante,c => 
            {
                c.WithOwner(nameof(Cadastro)).HasForeignKey("Id").HasConstraintName("IdCliente");
            });

            builder.OwnsOne(a => a.Categoria, ca =>
            {
                ca.WithOwner(nameof(Categoria)).HasForeignKey("Id").HasConstraintName("IdCategoria");
            });

            builder.OwnsOne(a => a.Contato, co =>
            {
                co.WithOwner(nameof(Contato)).HasForeignKey("Id").HasConstraintName("IdContato");
            });

            builder.Property(a => a.Descricao).IsRequired().HasColumnType("varchar(150)");
            builder.Property(a => a.Valor).IsRequired().HasColumnType("int");
            builder.Property(a => a.Titulo).IsRequired().HasColumnType("varchar(100)");

            builder.ToTable("Anunciar");
        }
    }
}




