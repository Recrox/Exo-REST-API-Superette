
using Technocite.Auchan.Superette.Core.Models;

namespace Data.Interfaces
{
    public interface ICategoryArticleRepository
    {
        IEnumerable<CategoryArticle> GetAll();
        Task AddAsync(CategoryArticle categoryArticle);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(CategoryArticle categoryArticle);
    }
}
