using System;

namespace Simplifique.Domain
{
    public class Cadastro
    {        
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public Cpf_Cnpj Cpf_Cnpj { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Telefone Telefone { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        public int Numero { get; set; }
        public Cep CEP { get; set; }
        public string Complemento { get; set; }
        public TipoPessoaEnum TipoPessoa { get; set; }
    }
}
