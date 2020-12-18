using System;
using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface ICadastroRepository
    {
        public Task<Cadastro> CadastrarUsuario(string nome,Cpf_Cnpj cpf_Cnpj,DateTime datanasc, Telefone telefone, Email email, string senha, Endereco endereco, int numero, Cep cep, string complemento, TipoPessoaEnum tipoPessoa);
        public Task<Cadastro> AlterarUsuario(Guid Id, Cadastro cliente);
    }
}
