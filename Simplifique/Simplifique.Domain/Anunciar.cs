using System;

namespace Simplifique.Domain
{
    public class Anunciar
    {
        public Guid IdAnuncio { get; set; }
        public Cadastro Anunciante { get; set; }
        public string Titulo { get; set; }
        public Contato Contato { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }

    }
}
