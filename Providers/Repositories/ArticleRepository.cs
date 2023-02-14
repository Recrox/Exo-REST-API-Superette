using AutoMapper;
using Data.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly WebSuperetteContext webSuperetteContext;
        private readonly IMapper mapper;

        public ArticleRepository(WebSuperetteContext webSuperetteContext,IMapper mapper)
        {
            this.webSuperetteContext = webSuperetteContext;
            this.mapper = mapper;
        }

        public async Task AddAsync(Article article)
        {
            await this.webSuperetteContext.Article.AddAsync(this.mapper.Map<Models.Article>(article));
            await this.webSuperetteContext.SaveChangesAsync();
        }

        public IEnumerable<Article> GetAll()
        {
            return this.mapper.Map<IEnumerable<Article>>(this.webSuperetteContext.Article);
        }

        public async Task RemoveByIdAsync(int id)
        {
             var article = await this.webSuperetteContext.Article.FindAsync(id);
            this.webSuperetteContext.Article.Remove(article);
            await this.webSuperetteContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Article article)
        {
            this.webSuperetteContext.Article.Update(this.mapper.Map<Models.Article>(article));
            await this.webSuperetteContext.SaveChangesAsync();
        }
    }
}
