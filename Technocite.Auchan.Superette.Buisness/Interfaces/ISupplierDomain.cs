
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Interfaces
{
    public interface ISupplierDomain
    {
        IEnumerable<Supplier> GetAll();
        Task AddAsync(Supplier supplier);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Supplier supplier);
    }
}
