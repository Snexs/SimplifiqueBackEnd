using Simplifique.Domain;
using Simplifique.Domain.Interfaces;
using System.Threading.Tasks;

namespace Simplifique.Infra.Repository
{
    public class AnunciarRepository : IAnunciarRepository
    {
        private readonly SimplifiqueContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public AnunciarRepository(SimplifiqueContext simplifiqueContext)
        {
            _context = simplifiqueContext;
        }

        public async Task<Anunciar> Anunciar(Cadastro anunciante, string titulo, Contato contato, string descricao, Categoria categoria, decimal valor)
        {
            var usuarioAnunciante = await _context.Cadastro.FindAsync(anunciante.Id);
            Anunciar anuncio = new Anunciar(anunciante,titulo,contato,descricao,categoria,valor);
            await _context.Anunciar.AddAsync(anuncio);
            await _context.Commit();
            return anuncio;
        }
    }
}
