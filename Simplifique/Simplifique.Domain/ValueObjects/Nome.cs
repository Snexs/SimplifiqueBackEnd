using Flunt.Validations;

namespace Simplifique.Domain.ValueObjects
{
    public class Nome : ObjetoDeValor
    {

        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }

        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            AddNotifications(new Contract().Requires().HasMinLen(primeiroNome, 5, "PrimeiroNome", "Nome deve conter mais que 5 caracteres")
                .HasMinLen(sobrenome, 5, "Sobrenome", "Sobrenome deve conter mais que 5 caracteres"));
        }
    }
}
