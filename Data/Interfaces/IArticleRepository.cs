using Technocite.Auchan.Superette.Core.Models;

namespace Data.Interfaces
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
    }
}
