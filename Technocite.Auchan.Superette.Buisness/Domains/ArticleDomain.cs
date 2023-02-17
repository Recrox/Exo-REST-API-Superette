
using Data.Interfaces;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class ArticleDomain : IArticleDomain
    {
        
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
