using System.ComponentModel.DataAnnotations;

namespace Simplifique.Models
{
    public class AnunciarModel : BaseModel
    {
        [Required]
        public CadastroModel IdAnunciante { get; set; }

        [Required]
        public ContatoModel Contato { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public CategoriaModel IdCategoria { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public AnunciarModel(CadastroModel idAnunciante,ContatoModel idContato,string descricao,CategoriaModel idCategoria,decimal valor)
        {
            this.IdAnunciante = idAnunciante;
            this.IdCategoria = idCategoria;
            this.Contato = idContato;
            this.Valor = valor;
            this.Descricao = descricao;
        }
    }
}
