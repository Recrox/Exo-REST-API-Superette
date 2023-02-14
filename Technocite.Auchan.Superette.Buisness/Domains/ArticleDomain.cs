
using Data.Interfaces;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class ArticleDomain : IArticleDomain
    {
        private readonly IArticleRepository articleRepository;

        public ArticleDomain(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public void Add(Article article)
        {
            this.articleRepository.Add(article);
        }

        public IEnumerable<Article> GetAll()
        {
            return this.articleRepository.GetAll();
        }
    }
}
