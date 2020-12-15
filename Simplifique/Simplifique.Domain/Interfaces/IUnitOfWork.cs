using System.Threading.Tasks;

namespace Simplifique.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
