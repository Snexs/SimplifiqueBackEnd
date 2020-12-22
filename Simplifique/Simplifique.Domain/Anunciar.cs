using Simplifique.Domain.Entities;

namespace Simplifique.Domain
{
    public class Anunciar : Entity
    {

        public Cadastro Anunciante { get; set; }
        public string Titulo { get; set; }
        public Contato Contato { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }

        public Anunciar(Cadastro anunciante, string titulo, Contato contato, string descricao, Categoria categoria, decimal valor)
        {
            Anunciante = anunciante;
            Titulo = titulo;
            Contato = contato;
            Descricao = descricao;
            Categoria = categoria;
            Valor = valor;
        }
    }
}
