using Simplifique.Domain;
using Simplifique.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Simplifique.Infra.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly SimplifiqueContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public ContatoRepository(SimplifiqueContext context)
        {
            _context = context;
        }

        public async Task<Contato> AdicionarContato(Guid IdUsuario, string facebook, string instagram, Telefone telefone, Telefone whatsapp, string email)
        {
            var contato = new Contato() { Email = email,Facebook = facebook,Instagram = instagram, WhatsApp = whatsapp, Telefone = telefone };
            await _context.AddAsync(contato);
            await _context.Commit();
            return contato;
        }

        public async Task<Contato> AtualizarContato(Guid IdUsuario, Contato contactItem)
        {
            var clienteAntigo = await _context.Contato.FindAsync(IdUsuario);
            _context.Entry(clienteAntigo).CurrentValues.SetValues(contactItem);
            await _context.Commit();
            return contactItem;
        }
    }
}
