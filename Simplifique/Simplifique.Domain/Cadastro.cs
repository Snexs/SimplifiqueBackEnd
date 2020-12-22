using Simplifique.Domain.Entities;
using Simplifique.Domain.Enums;
using Simplifique.Domain.ValueObjects;
using System;

namespace Simplifique.Domain
{
    public class Cadastro : Entity
    {
        public Nome Nome { get; set; }
        public Documento Cpf_Cnpj { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Telefone Telefone { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        public TipoPessoaEnum TipoPessoa { get; set; }

        public Cadastro(Nome nome, Documento cpf_Cnpj, DateTime dataDeNascimento, Telefone telefone, Email email, string senha, Endereco endereco, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Cpf_Cnpj = cpf_Cnpj;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Endereco = endereco;
            TipoPessoa = tipoPessoa;

            AddNotifications(nome, cpf_Cnpj, telefone, email, endereco);
        }
    }
}
