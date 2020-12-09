using System;

namespace Simplifique.Domain
{
    public class Anunciar
    {
        public Guid IdAnuncio { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }
        public double TelefoneContato { get; set; }

    }
}
