using AutoMapper;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Repositories
{
    public class CategoryArticleRepository : ICategoryArticleRepository
    {
        private readonly WebSuperetteContext webSuperetteContext;
        private readonly IMapper mapper;

        public CategoryArticleRepository(WebSuperetteContext webSuperetteContext, IMapper mapper)
        {
            this.webSuperetteContext = webSuperetteContext;
            this.mapper = mapper;
        }

        public IEnumerable<CategoryArticle> GetAll()
        { 
            return this.mapper.Map<IEnumerable<CategoryArticle>>(this.webSuperetteContext.CategoryArticle);
        }

        public async Task AddAsync(CategoryArticle categoryArticle)
        {
            await this.webSuperetteContext.CategoryArticle.AddAsync(this.mapper.Map<Models.CategoryArticle>(categoryArticle));
            await this.webSuperetteContext.SaveChangesAsync();
        }

        public async Task RemoveByIdAsync(int id)
        {
            var categoryArticle =  await this.webSuperetteContext.CategoryArticle.FindAsync(id);
            this.webSuperetteContext.CategoryArticle.Remove(categoryArticle);
            await this.webSuperetteContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(CategoryArticle categoryArticle)
        {
            this.webSuperetteContext.Update(categoryArticle);
            await this.webSuperetteContext.SaveChangesAsync();
        }
    }
}
