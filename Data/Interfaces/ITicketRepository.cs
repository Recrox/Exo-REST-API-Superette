
using System.Net.Sockets;
using Technocite.Auchan.Superette.Core.Models;

namespace Data.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Task AddAsync(Ticket ticket);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Ticket ticket);
    }
}
