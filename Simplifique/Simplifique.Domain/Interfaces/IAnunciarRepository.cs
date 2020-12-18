using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface IAnunciarRepository
    {
        public Task<Anunciar> Anunciar(decimal valor,string descricao,Categoria categoria,Contato contato,string titulo,Cadastro IdUsuario);
    }
}
