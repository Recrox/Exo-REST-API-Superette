
using Data.Interfaces;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Domains
{
    public class CategoryArticleDomain : ICategoryArticleDomain
    {
        private readonly ICategoryArticleRepository categoryArticleRepository;
        private readonly IArticleRepository articleRepository;

        public CategoryArticleDomain(ICategoryArticleRepository categoryArticleRepository,IArticleRepository articleRepository)
        {
            this.categoryArticleRepository = categoryArticleRepository;
            this.articleRepository = articleRepository;
        }
        public async Task AddAsync(CategoryArticle categoryArticle)
        {
            await this.categoryArticleRepository.AddAsync(categoryArticle);
        }

        public IEnumerable<CategoryArticle> GetAll()
        {
            return this.categoryArticleRepository.GetAll();
        }

        public async Task RemoveByIdAsync(int id)
        {
            if (this.articleRepository.ContainsCategoryId(id))
            {
                throw new Exception("An article is bind with this category, so you can't remove this category");
            }
            await this.categoryArticleRepository.RemoveByIdAsync(id);
        }

        public async Task UpdateAsync(CategoryArticle categoryArticle)
        {
            await this.categoryArticleRepository.UpdateAsync(categoryArticle);
        }
    }
}
