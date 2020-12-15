using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface ICategoriaRepository : IDisposable
    {
        public Task<List<Categoria>> ConsultarCategorias();
        public Task<Categoria> CadastrarCategoria(Categoria categoriaItem);
        public Task<Categoria> AtualizarCategoria(Guid id, Categoria categoriaItem);
        public Task<Categoria> ConsultarCategoriaPorId(Guid id);
    }
}
