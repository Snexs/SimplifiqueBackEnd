using System.ComponentModel.DataAnnotations;

namespace Simplifique.Models
{
    public class LoginModel : BaseModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }

        public LoginModel(string email,string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }
    }
}
