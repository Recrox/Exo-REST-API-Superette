
namespace Technocite.Auchan.Superette.Core.Models
{
    public class ArticleTicket
    {
        public int ArticleId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        //public virtual Article Article { get; set; } = null!;
    }
}
