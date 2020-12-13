using System.ComponentModel.DataAnnotations;

namespace Simplifique.Models
{
    public class CategoriaModel : BaseModel
    {        
        [Required]
        public string Nome { get; private set; }

        public CategoriaModel(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
