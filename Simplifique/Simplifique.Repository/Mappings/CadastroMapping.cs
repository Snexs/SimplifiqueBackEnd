using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class CadastroMapping : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.HasKey(c => c.IdUsuario);

            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.Cpf_Cnpj).IsRequired().HasColumnType("bigint");
            builder.Property(c => c.Email).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.DataDeNascimento).IsRequired().HasColumnType("datetime");
            builder.Property(c => c.Endereco).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.CEP).IsRequired().HasColumnType("int");
            builder.Property(c => c.Numero).IsRequired().HasColumnType("int");
            builder.Property(c => c.Complemento).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.Senha).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.Telefone).IsRequired().HasColumnType("bigint");
            builder.Property(c => c.TipoPessoa).IsRequired().HasColumnType("byte");

            builder.ToTable("Cadastro");
        }
    }
}
