using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simplifique.Domain;

namespace Simplifique.Infra.Mappings
{
    public class CadastroMapping : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.HasKey(c => c.Id).HasName("IdCadastro");

            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.DataDeNascimento).IsRequired().HasColumnType("datetime");
            builder.Property(c => c.Senha).IsRequired().HasColumnType("varchar(100)");
            builder.Property(c => c.TipoPessoa).IsRequired().HasColumnType("byte");

            builder.OwnsOne(c => c.Cpf_Cnpj, c =>
            {
                c.Property(c => c.Numero).IsRequired().HasColumnType("bigint");
            });

            builder.OwnsOne(c => c.Email, c =>
            {
                c.Property(c => c.EnderecoEmail).IsRequired().HasColumnType("varchar(150)");
            });

            builder.OwnsOne(c => c.Endereco, c =>
            {
                c.Property(c => c.NomeEndereco).IsRequired().HasColumnType("varchar(150)");
                c.Property(c => c.Numero).IsRequired().HasColumnType("int");
                c.Property(c => c.Cidade).IsRequired().HasColumnType("varchar(150)");
                c.Property(c => c.Cep).IsRequired().HasColumnType("int");
                c.Property(c => c.Estado).IsRequired().HasColumnType("varchar(150)");
            });

            builder.OwnsOne(c => c.Telefone, c =>
            {
                c.Property(c => c.Ddd).IsRequired().HasColumnType("int");
                c.Property(c => c.Numero).IsRequired().HasColumnType("int");
            });

            builder.ToTable("Cadastro");
        }
    }
}
