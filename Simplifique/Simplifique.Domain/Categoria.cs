using Simplifique.Domain.Entities;

namespace Simplifique.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }

        public Categoria() { }

        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
}
