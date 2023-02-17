namespace Providers.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name_Article { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        //public ICollection<ArticleTicket> ArticleTickets { get; set; } = null!;
    }
}