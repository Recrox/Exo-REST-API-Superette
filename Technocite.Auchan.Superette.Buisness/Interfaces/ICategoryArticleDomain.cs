
using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Interfaces
{
    public interface ICategoryArticleDomain
    {
        IEnumerable<CategoryArticle> GetAll();
        Task AddAsync(CategoryArticle categoryArticle);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(CategoryArticle categoryArticle);
    }
}
