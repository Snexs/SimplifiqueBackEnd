using Simplifique.Domain;
using Simplifique.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Simplifique.Infra.Repository
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private readonly SimplifiqueContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public AnuncioRepository(SimplifiqueContext simplifiqueContext)
        {
            _context = simplifiqueContext;
        }

        public async Task<Anuncio> EditarAnuncio(Guid id, Anuncio anuncioItem)
        {
            var anuncio = await _context.Anuncio.FindAsync(id);
            _context.Entry(anuncio).CurrentValues.SetValues(anuncioItem);
            await UnitOfWork.Commit();
            return anuncioItem;
        }

        public async Task ExcluirAnuncio(Guid id)
        {
            var anuncio = await _context.Anuncio.FindAsync(id);
            _context.Anuncio.Remove(anuncio);
        }

        public Task<Anuncio> PromoverAnuncio(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
