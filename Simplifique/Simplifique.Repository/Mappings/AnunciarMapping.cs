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

            builder.Property(a => a.Anunciante).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.Categoria).IsRequired().HasColumnType("varchar(60)");
            builder.Property(a => a.Contato).IsRequired().HasColumnType("varchar(150)");
            builder.Property(a => a.Descricao).IsRequired().HasColumnType("varchar(150)");
            builder.Property(a => a.Valor).IsRequired().HasColumnType("int");
            builder.Property(a => a.Titulo).IsRequired().HasColumnType("varchar(100)");

            builder.ToTable("Anunciar");
        }
    }
}




