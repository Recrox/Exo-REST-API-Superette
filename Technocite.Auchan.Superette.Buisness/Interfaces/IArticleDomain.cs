using Technocite.Auchan.Superette.Core.Models;

namespace Technocite.Auchan.Superette.Buisness.Interfaces
{
    public interface IArticleDomain
    {
        IEnumerable<Article> GetAll();
        void Add(Article article);
    }
}
