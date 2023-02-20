using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Site.ViewModels;

namespace Technocite.Auchan.Superette.Site.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ITicketDomain ticketDomain;

        public TicketController(IMapper mapper,ITicketDomain ticketDomain)
        {
            this.mapper = mapper;
            this.ticketDomain = ticketDomain;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tickets = this.ticketDomain.GetAll();

            return this.Ok(this.mapper.Map<IEnumerable<Ticket>>(tickets));
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(Ticket ticket)
        {
            try
            {
                await this.ticketDomain.AddAsync(this.mapper.Map<Core.Models.Ticket>(ticket));
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Buy(IEnumerable<ArticleTicket> articles)
        {
            try
            {
                var ticket = await this.ticketDomain.Buy(this.mapper.Map<IEnumerable<Core.Models.ArticleTicket>>(articles));
                return this.Ok(ticket);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

    }
}
