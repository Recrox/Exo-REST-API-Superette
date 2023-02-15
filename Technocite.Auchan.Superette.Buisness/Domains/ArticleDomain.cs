
using Data.Interfaces;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class ArticleDomain : IArticleDomain
    {
        private const decimal CoefTva = (decimal)1.06;
        private readonly IArticleRepository articleRepository;
        private readonly ITicketRepository ticketRepository;

        public ArticleDomain(IArticleRepository articleRepository,ITicketRepository ticketRepository)
        {
            this.articleRepository = articleRepository;
            this.ticketRepository = ticketRepository;
        }

        public async Task AddAsync(Article article)
        {
            if (article.Quantity < 0)
            {
                throw new Exception("Quantity not valid");
            }
            await this.articleRepository.AddAsync(article);
        }

        public async Task Buy(IEnumerable<Article> articles)
        {
            var priceArticles = articles.Sum(a => a.Price*a.Quantity);

            await this.ticketRepository.AddAsync(new Ticket
            {
                Articles = articles,
                PriceHtva = priceArticles,
                PriceTTC = priceArticles * CoefTva,
            });
            
            
        }

        public IEnumerable<Article> GetAll()
        {
            return this.articleRepository.GetAll();
        }

        public async Task RemoveByIdAsync(int id)
        {
            await this.articleRepository.RemoveByIdAsync(id);
        }

        public async Task UpdateAsync(Article article)
        {
            if (article.Quantity < 0)
            {
                throw new Exception("Quantity not valid");
            }
            await this.articleRepository.UpdateAsync(article);
        }
    }
}
