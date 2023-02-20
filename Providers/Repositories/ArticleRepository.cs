using AutoMapper;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            try
            {
                await this.webSuperetteContext.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
            
        }

        public bool ContainsCategoryId(int categoryId)
        {
            return this.webSuperetteContext.Article.Where(a=>a.CategoryId== categoryId).Any();
        }

        public IEnumerable<Article> GetAll()
        {
            return this.mapper.Map<IEnumerable<Article>>(this.webSuperetteContext.Article
                //.Include(a => a.ArticleTickets)
                );
        }

        public async Task<Article?> GetByIdAsync(int id)
        {
            var article = await this.webSuperetteContext.Article
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);

            return this.mapper.Map<Article>(article);
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
