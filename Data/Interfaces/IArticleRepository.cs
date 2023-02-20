using Technocite.Auchan.Superette.Core.Models;

namespace Data.Interfaces
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
        Task<Article?> GetByIdAsync(int id);
        Task AddAsync(Article article);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Article article);
        bool ContainsCategoryId(int categoryId);
    }
}
