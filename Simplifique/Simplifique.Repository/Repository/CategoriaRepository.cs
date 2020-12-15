using Simplifique.Domain;
using Simplifique.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simplifique.Infra.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly SimplifiqueContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public CategoriaRepository(SimplifiqueContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<List<Categoria>> ConsultarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            lista.Add(await _context.Categoria.FindAsync());
            return lista;
        }

        public async Task<Categoria> CadastrarCategoria(Categoria categoriaItem)
        {
            await _context.Categoria.AddAsync(categoriaItem);
            await UnitOfWork.Commit();
            return categoriaItem;
        }

        public async Task<Categoria> AtualizarCategoria(Guid id, Categoria categoriaItem)
        {
            var antigo = await _context.Categoria.FindAsync(id);
            _context.Entry(antigo).CurrentValues.SetValues(categoriaItem);
            await UnitOfWork.Commit();
            return categoriaItem;
        }

        public async Task<Categoria> ConsultarCategoriaPorId(Guid id)
        {
            var response = await _context.Categoria.FindAsync(id);
            return response;
        }
    }
}
