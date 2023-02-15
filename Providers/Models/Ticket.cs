namespace Providers.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public decimal PriceHtva { get; set; }
        public decimal PriceTTC { get; set; }


        public ICollection<Article> Articles { get; set; }
    }
}
