using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class AnuncioMapping : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.Property(a => a.Avaliacao).IsRequired().HasColumnType("byte");
            builder.Property(a => a.Comentario).IsRequired().HasColumnType("varchar(200)");

            builder.OwnsOne(a => a.Contato,  contato => 
            {
                contato.WithOwner().HasForeignKey("Id").HasConstraintName("IdContato");
                contato.Property(c => c.Facebook).HasColumnType("varchar(100)");
                contato.Property(c => c.Email).IsRequired().HasColumnType("varchar(100)");
                contato.Property(c => c.Instagram).HasColumnType("varchar(100)");
                contato.Property(c => c.Telefone).HasColumnType("varchar(100)");
                contato.Property(c => c.WhatsApp).IsRequired().HasColumnType("varchar(100)");
            });

            builder.Property(a => a.Descricao).IsRequired().HasColumnType("varchar(150)");
            builder.Property(a => a.ObservacaoContato).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.Valor).IsRequired().HasColumnType("int");
            builder.Property(a => a.Titulo).IsRequired().HasColumnType("varchar(150)");

            builder.ToTable("Anuncio");
        }
    }
}

