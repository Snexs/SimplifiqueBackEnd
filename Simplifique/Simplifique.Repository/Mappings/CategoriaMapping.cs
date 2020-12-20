using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.IdCategoria);

            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(60)");

            builder.ToTable("Categoria");

        }
    }
}
