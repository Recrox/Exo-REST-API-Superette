
namespace Providers.Models
{
    public class CategoryArticle
    {

        public int Id { get; set; }

        public string CategoryName { get; set; }

        public IEnumerable<CategoryArticle> CategoryArticles { get; set; }
    }
}
