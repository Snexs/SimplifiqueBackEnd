using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface IAnunciarRepository
    {
        public Task<Anunciar> Anunciar(Cadastro anunciante, string titulo, Contato contato, string descricao, Categoria categoria, decimal valor);
    }
}
