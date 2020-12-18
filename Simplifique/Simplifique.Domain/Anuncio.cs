using System;

namespace Simplifique.Domain
{
    public class Anuncio
    {
        public Guid IdAnuncio { get; set; }
        public string Titulo { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public string Comentario { get; set; }
        public Contato Contato { get; set; }
        public string ObservacaoContato { get; set; }

    }
}
