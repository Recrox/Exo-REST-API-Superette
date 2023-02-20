using Data.Interfaces;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class TicketDomain : ITicketDomain
    {
        private const decimal CoefTva = (decimal)1.06;
        private readonly ITicketRepository ticketRepository;
        private readonly IArticleRepository articleRepository;

        public TicketDomain(ITicketRepository ticketRepository, IArticleRepository articleRepository)
        {
            this.ticketRepository = ticketRepository;
            this.articleRepository = articleRepository;
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

        public async Task<Ticket> Buy(IEnumerable<ArticleTicket> articles)
        {
            decimal total = 0;
            foreach (var article in articles)
            {
                var articleDb = await this.articleRepository.GetByIdAsync(article.ArticleId);
                if (articleDb == null)
                {
                    throw new Exception("Article introuvable");
                }

                if (articleDb.Quantity<article.Quantity)
                {
                    throw new Exception("il n'y a pas assez d'article dispo");
                }

                articleDb.Quantity -= article.Quantity;

                await this.articleRepository.UpdateAsync(articleDb);

                total += articleDb.Price * article.Quantity;
            }

            var newTicket = new Ticket
            {
                PriceHtva = total,
                PriceTTC = total * CoefTva,
                ArticleTicket = articles,
                
            };
            
            await this.ticketRepository.AddAsync(newTicket);


            return newTicket;

        }

        public async Task<Ticket> GetDetails(int id)
        {
            var ticket = await this.ticketRepository.GetByIdAsync(id);

            return ticket;


        }
    }
}
