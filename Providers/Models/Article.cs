namespace Providers.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name_Article { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}