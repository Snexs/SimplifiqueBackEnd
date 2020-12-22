using Simplifique.Domain.ValueObjects;
using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface IContatoRepository
    {
        Task<Contato> AdicionarContato(Cadastro IdUsuario,string facebook,string instagram,Telefone telefone,Telefone whatsapp,string email);
        Task<Contato> AtualizarContato(Cadastro IdUsuario,Contato contactItem);
    }
}
