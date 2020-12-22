using Flunt.Validations;

namespace Simplifique.Domain.ValueObjects
{
    public class Endereco : ObjetoDeValor
    {

        public string NomeEndereco { get; private set; }
        public string Complemento { get; private set; }
        public int Numero { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Cep Cep { get; private set; }

        public Endereco(){}

        public Endereco(string nomeEndereco, string complemento, int numero, string cidade, string estado, Cep cep)
        {
            NomeEndereco = nomeEndereco;
            Complemento = complemento;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;

            AddNotifications(new Contract().Requires().HasMinLen(nomeEndereco,5,"NomeEndereco","O Endereco deve ser maior que 5 caracteres")
                .HasMinLen(cidade, 5, "Cidade", "Cidade deve ter pelo menos 5 caracteres")
                .HasMinLen(estado, 5, "Estado", "Estado deve ter pelo menos 5 caracteres"));
        }
    }
}
