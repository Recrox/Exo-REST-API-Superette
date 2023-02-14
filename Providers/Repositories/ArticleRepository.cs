using Data.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly WebSuperetteContext webSuperetteContext;

        public ArticleRepository(WebSuperetteContext webSuperetteContext)
        {
            this.webSuperetteContext = webSuperetteContext;
        }

        public IEnumerable<Article> GetAll()
        {
            throw new Exception();
        }
    }
}
