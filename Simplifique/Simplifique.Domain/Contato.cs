using Simplifique.Domain.Entities;
using Simplifique.Domain.ValueObjects;

namespace Simplifique.Domain
{
    public class Contato : Entity
    {
        public Cadastro IdUsuario { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public Telefone WhatsApp { get; set; }

        public string Email { get; set; }

        public Telefone Telefone { get; set; }

        public Contato(Cadastro idUsuario, string facebook, string instagram, Telefone whatsApp, string email, Telefone telefone)
        {
            IdUsuario = idUsuario;
            Facebook = facebook;
            Instagram = instagram;
            WhatsApp = whatsApp;
            Email = email;
            Telefone = telefone;
        }
    }
}
