﻿using Simplifique.Domain;
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

        public async Task<Anunciar> Anunciar(decimal valor, string descricao, Categoria categoria, Contato contato, string titulo,Cadastro user)
        {
            var anunciante = await _context.Cadastro.FindAsync(user.Id);
            Anunciar anuncio = new Anunciar(anunciante,titulo,contato,descricao,categoria,valor);
            await _context.Anunciar.AddAsync(anuncio);
            await _context.Commit();
            return anuncio;
        }
    }
}
