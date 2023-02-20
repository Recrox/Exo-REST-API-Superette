

namespace Providers.Models
{
    public class ArticleTicket
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TicketId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Article Article { get; set; } = null!;
        /*public Article Article { get; set; }
        public Ticket Ticket { get; set; }*/
    }
}
