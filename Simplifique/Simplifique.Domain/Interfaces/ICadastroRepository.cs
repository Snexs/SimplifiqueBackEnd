using Simplifique.Domain.Enums;
using Simplifique.Domain.ValueObjects;
using System;
using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface ICadastroRepository
    {
        public Task<Cadastro> CadastrarUsuario(Nome nome, Documento cpf_Cnpj, DateTime datanasc, Telefone telefone, Email email, string senha, Endereco endereco, int numero, Cep cep, string complemento, TipoPessoaEnum tipoPessoa);
        public Task<Cadastro> AlterarUsuario(Guid Id, Cadastro cliente);
    }
}
