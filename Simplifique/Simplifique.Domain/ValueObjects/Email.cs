using Flunt.Validations;
using System.Text.RegularExpressions;

namespace Simplifique.Domain.ValueObjects
{
    public class Email : ObjetoDeValor
    {
        public string EnderecoEmail { get; private set; }

        public Email() { }

        public Email(string email)
        {
            EnderecoEmail = email;

            AddNotifications(new Contract().Requires().IsTrue(ValidaEmail(email),"EnderecoEmail", "Email Invalido"));
        }

        private bool ValidaEmail(string email)
        {
            Regex regexEmail = new Regex(@"\w+@\w+\.\w+\.?\w?\w?");

            var validacao = regexEmail.Match(email);

            if (validacao.Success)
                return true;

            return false;
        }
    }
}