using Technocite.Auchan.Superette.Core.Models;

namespace Data.Interfaces
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
        Task AddAsync(Article article);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Article article);
    }
}
