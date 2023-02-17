
using Technocite.Auchan.Superette.Core.Models;

namespace Data.Interfaces
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetAll();
        Task AddAsync(Supplier supplier);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Supplier supplier);
    }
}
