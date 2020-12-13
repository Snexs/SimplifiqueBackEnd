using System;
using System.Collections.Generic;

namespace Simplifique.Domain
{
    public class Anuncio
    {
        public Guid IdAnuncio { get; set; }
        public Anunciar IdAnunciar { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public string Comentario { get; set; }
        public List<string> Contato { get; set; }
        public string ObservacaoContato { get; set; }

    }
}
