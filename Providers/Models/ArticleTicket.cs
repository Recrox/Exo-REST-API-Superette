

namespace Providers.Models
{
    public class ArticleTicket
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TicketId { get; set; }

        public int Quantity { get; set; }

        /*public Article Article { get; set; }
        public Ticket Ticket { get; set; }*/
    }
}
