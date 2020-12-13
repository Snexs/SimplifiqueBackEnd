using System.ComponentModel.DataAnnotations;

namespace Simplifique.Models
{
    public class ContatoModel : BaseModel
    {
        [Required]
        public AnunciarModel IdAnunciar { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        [Required]
        public float WhatsApp { get; set; }

        [Required]
        public string Email { get; set; }

        public float Telefone { get; set; }

        public ContatoModel(AnunciarModel idAnunciar,float whatsapp,string email,string facebook,string instagram,float telefone)
        {
            this.IdAnunciar = idAnunciar;
            this.Instagram = instagram;
            this.Telefone = telefone;
            this.WhatsApp = whatsapp;
            this.Facebook = facebook;
            this.Email = email;
        }

        public ContatoModel(AnunciarModel idAnunciar, float whatsapp, string email, string instagram, float telefone)
        {
            this.IdAnunciar = idAnunciar;
            this.Instagram = instagram;
            this.Telefone = telefone;
            this.WhatsApp = whatsapp;
            this.Email = email;
        }

        public ContatoModel(AnunciarModel idAnunciar, float whatsapp, string email)
        {
            this.IdAnunciar = idAnunciar;
            this.WhatsApp = whatsapp;
            this.Email = email;
        }

        public ContatoModel(AnunciarModel idAnunciar, float whatsapp, string email, string facebook)
        {
            this.IdAnunciar = idAnunciar;
            this.WhatsApp = whatsapp;
            this.Facebook = facebook;
            this.Email = email;
        }

        public ContatoModel(AnunciarModel idAnunciar, float whatsapp, string email, float telefone, string facebook)
        {
            this.IdAnunciar = idAnunciar;
            this.Telefone = telefone;
            this.WhatsApp = whatsapp;
            this.Facebook = facebook;
            this.Email = email;
        }

        public ContatoModel(AnunciarModel idAnunciar, float whatsapp, string email, string facebook, string instagram)
        {
            this.IdAnunciar = idAnunciar;
            this.Instagram = instagram;
            this.WhatsApp = whatsapp;
            this.Facebook = facebook;
            this.Email = email;
        }
    }
}
