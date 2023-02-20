
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Interfaces
{
    public interface ITicketDomain
    {
        IEnumerable<Ticket> GetAll();
        Task AddAsync(Ticket ticket);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Ticket ticket);
        Task<Ticket> Buy(IEnumerable<ArticleTicket> articles);
    }
}
