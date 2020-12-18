using System;
using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface IAnuncioRepository
    {
        public Task<Anuncio> EditarAnuncio(Guid id,Anuncio anuncioItem);
        public Task ExcluirAnuncio(Guid id);
        public Task<Anuncio> PromoverAnuncio(Guid id);
    }
}
