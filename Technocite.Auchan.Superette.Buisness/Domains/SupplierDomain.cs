using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class SupplierDomain : ISupplierDomain
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierDomain(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        public async Task AddAsync(Supplier supplier)
        {
             await this.supplierRepository.AddAsync(supplier);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return this.supplierRepository.GetAll();
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
