using System;

namespace Simplifique.Domain
{
    public class Cadastro
    {
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public double Cpf_Cnpj { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Complemento { get; set; }

    }
}
