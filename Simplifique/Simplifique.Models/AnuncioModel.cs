using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simplifique.Models
{
    public class AnuncioModel : BaseModel
    {
        [Required]
        public AnunciarModel IdAnunciar { get; set; }
        
        [Required]
        public decimal Valor { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public int Avaliacao { get; set; }

        public string Comentario { get; set; }
        
        [Required]
        public List<string> Contato { get; set; }

        public string ObservacaoContato { get; set; }

        public AnuncioModel(AnunciarModel idAnunciar,decimal valor,string descricao,int avaliacao,string comentario,List<string> contato,string obsContato)
        {
            this.Contato = contato;
            this.ObservacaoContato = obsContato;
            this.Valor = valor;
            this.IdAnunciar = idAnunciar;
            this.Descricao = descricao;
            this.Contato = contato;
            this.Comentario = comentario;
            this.Avaliacao = avaliacao;
        }

        public AnuncioModel(AnunciarModel idAnunciar, decimal valor, string descricao, int avaliacao, string comentario, List<string> contato)
        {
            this.Contato = contato;
            this.Valor = valor;
            this.IdAnunciar = idAnunciar;
            this.Descricao = descricao;
            this.Contato = contato;
            this.Comentario = comentario;
            this.Avaliacao = avaliacao;
        }

        public AnuncioModel(AnunciarModel idAnunciar, decimal valor, string descricao, int avaliacao, List<string> contato, string obsContato)
        {
            this.Contato = contato;
            this.ObservacaoContato = obsContato;
            this.Valor = valor;
            this.IdAnunciar = idAnunciar;
            this.Descricao = descricao;
            this.Contato = contato;
            this.Avaliacao = avaliacao;
        }

        public AnuncioModel(AnunciarModel idAnunciar, decimal valor, string descricao, int avaliacao, List<string> contato)
        {
            this.Contato = contato;
            this.Valor = valor;
            this.IdAnunciar = idAnunciar;
            this.Descricao = descricao;
            this.Contato = contato;
            this.Avaliacao = avaliacao;
        }
    }
}
