using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Site.ViewModels;

namespace Technocite.Auchan.Superette.Site.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierDomain supplierDomain;
        private readonly IMapper mapper;

        public SupplierController(ISupplierDomain supplierDomain, IMapper mapper)
        {
            this.supplierDomain = supplierDomain;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var tickets = this.supplierDomain.GetAll();

            return this.Ok(this.mapper.Map<IEnumerable<Supplier>>(tickets));
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(Supplier supplier)
        {
            try
            {
                await this.supplierDomain.AddAsync(this.mapper.Map<Core.Models.Supplier>(supplier));
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
