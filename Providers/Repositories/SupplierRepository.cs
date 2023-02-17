using AutoMapper;
using Data.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly WebSuperetteContext webSuperetteContext;
        private readonly IMapper mapper;

        public SupplierRepository(WebSuperetteContext webSuperetteContext,IMapper mapper) {
            this.webSuperetteContext = webSuperetteContext;
            this.mapper = mapper;
        }
        public async Task AddAsync(Supplier supplier)
        {
            var supplierDb = this.mapper.Map<Models.Supplier>(supplier);
            await this.webSuperetteContext.Supplier.AddAsync(supplierDb);
            await this.webSuperetteContext.SaveChangesAsync();
        }

        public IEnumerable<Supplier> GetAll()
        {

            var suppliers = this.webSuperetteContext.Supplier;

            return this.mapper.Map<IEnumerable<Supplier>>(suppliers);

        }

        public Task RemoveByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
