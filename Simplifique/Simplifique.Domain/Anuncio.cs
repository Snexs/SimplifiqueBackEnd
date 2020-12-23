using Simplifique.Domain.Entities;

namespace Simplifique.Domain
{
    public class Anuncio : Entity
    {
        public string Titulo { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public string Comentario { get; set; }
        public Contato Contato { get; set; }
        public string ObservacaoContato { get; set; }

        public Anuncio() { }

        public Anuncio(string titulo, decimal valor, string descricao, int avaliacao, string comentario, Contato contato, string observacaoContato)
        {
            Titulo = titulo;
            Valor = valor;
            Descricao = descricao;
            Avaliacao = avaliacao;
            Comentario = comentario;
            Contato = contato;
            ObservacaoContato = observacaoContato;
        }
    }
}
