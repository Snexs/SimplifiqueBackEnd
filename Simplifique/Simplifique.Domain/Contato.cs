using System;

namespace Simplifique.Domain
{
    public class Contato
    {
        public Guid IdContato { get; set; }
        public Cadastro IdUsuario { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public float WhatsApp { get; set; }

        public string Email { get; set; }

        public float Telefone { get; set; }

    }
}
