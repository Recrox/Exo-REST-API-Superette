using Data.Interfaces;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class TicketDomain : ITicketDomain
    {
        private readonly ITicketRepository ticketRepository;

        public TicketDomain(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public async Task AddAsync(Ticket ticket)
        {
            await this.ticketRepository.AddAsync(ticket);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return  this.ticketRepository.GetAll();
        }

        public Task RemoveByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
