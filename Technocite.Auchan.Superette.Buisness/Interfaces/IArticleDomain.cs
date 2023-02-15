using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Interfaces
{
    public interface IArticleDomain
    {
        IEnumerable<Article> GetAll();
        Task AddAsync(Article article);
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(Article article);
        Task Buy(IEnumerable<Article> articles);
    }
}
