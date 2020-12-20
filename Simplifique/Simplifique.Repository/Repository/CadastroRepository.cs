using Simplifique.Domain;
using Simplifique.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Simplifique.Infra.Repository
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly SimplifiqueContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public CadastroRepository(SimplifiqueContext context)
        {
            _context = context;
        }

        public async Task<Cadastro> AlterarUsuario(Guid id, Cadastro cliente)
        {
            var clienteAntigo = await _context.Cadastro.FindAsync(id);
            _context.Entry(clienteAntigo).CurrentValues.SetValues(cliente);
            await _context.Commit();
            return cliente;
        }

        public async Task<Cadastro> CadastrarUsuario(string nome, Cpf_Cnpj cpf_Cnpj, DateTime datanasc, Telefone telefone, Email email, string senha, Endereco endereco, int numero, Cep cep, string complemento, TipoPessoaEnum tipoPessoa)
        {
            Cadastro cliente = new Cadastro() {Nome = nome,CEP = cep, Complemento = complemento, DataDeNascimento = datanasc, Cpf_Cnpj = cpf_Cnpj, Email = email, Endereco = endereco, Numero = numero , Senha = senha, Telefone = telefone, TipoPessoa = tipoPessoa };
            await _context.Cadastro.AddAsync(cliente);
            await _context.Commit();
            return cliente;
        }
    }
}
