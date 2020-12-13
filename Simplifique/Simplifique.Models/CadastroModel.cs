using System;
using System.ComponentModel.DataAnnotations;

namespace Simplifique.Models
{
    public class CadastroModel : BaseModel
    {
        [Required]
        public string Nome { get; private set; }

        [Required]
        public double Cpf_Cnpj { get; private set; }

        [Required]
        public DateTime DataDeNascimento { get; private set; }

        [Required]
        public double Telefone { get; private set; }

        [Required]
        public string Email { get; private set; }

        [Required]
        public string Senha { get; private set; }

        [Required]
        public string Endereco { get; private set; }

        [Required]
        public int Numero { get; private set; }

        [Required]
        public int CEP { get; private set; }

        public string Complemento { get; private set; }

        public CadastroModel(string nome,double cpf_cnpj,DateTime dateNasc,double telefone,string email,string senha,string endereco,int numero,int cep)
        {
            this.Nome = nome;
            this.Cpf_Cnpj = cpf_cnpj;
            this.DataDeNascimento = dateNasc;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = endereco;
            this.Senha = senha;
            this.Numero = numero;
            this.CEP = cep;
        }

        public CadastroModel(string nome, double cpf_cnpj, DateTime dateNasc, double telefone, string email, string senha, string endereco, int numero, int cep, string complemento)
        {
            this.Nome = nome;
            this.Cpf_Cnpj = cpf_cnpj;
            this.DataDeNascimento = dateNasc;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = endereco;
            this.Senha = senha;
            this.Numero = numero;
            this.CEP = cep;
            this.Complemento = complemento;
        }
    }
}
