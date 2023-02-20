
namespace Technocite.Auchan.Superette.Core.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int EcoScore { get; set; }


        public IEnumerable<Article> Articles { get; set; }
    }
}
