namespace Technocite.Auchan.Superette.Site.ViewModels
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public decimal PriceHtva { get; set; }
        public decimal PriceTTC { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
