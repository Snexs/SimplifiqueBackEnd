using System;
using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface IContatoRepository
    {
        Task<Contato> AdicionarContato(Guid IdUsuario,string facebook,string instagram,Telefone telefone,Telefone whatsapp,string email);
        Task<Contato> AtualizarContato(Guid IdUsuario,Contato contactItem);
    }
}
