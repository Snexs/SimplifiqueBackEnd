namespace Simplifique.Domain
{
    public class Email
    {
        public string Dominio { get; private set; }
        public string User { get; private set; }

        public string EnderecoEmail => $"{User}@{Dominio}";

        public Email(string enderecoEmail)
        {
            //Validacao

            var email1 = new Email("joaoga@pbtech.net.br");
            var email2 = new Email("joaoga@pbtech.net.br");

        }


    }
}