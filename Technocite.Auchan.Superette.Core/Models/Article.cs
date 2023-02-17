namespace Technocite.Auchan.Superette.Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name_Article { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        /*public IEnumerable<Ticket> ArticleTicket { get; set; }*/
        
        /*public IEnumerable<Ticket> Tickets { get; set; }*/

        /*private Article(int id, string name_Article, string brand, decimal price, int quantity, int categoryId, IEnumerable<Ticket> tickets)
        {
            Id = id;
            Name_Article = name_Article;
            Brand = brand;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryId;
            Tickets = tickets;
        }*/

        /*public Article Create(int id, 
            string name_Article, 
            string brand, 
            decimal price, 
            int quantity, 
            int categoryId, 
            IEnumerable<Ticket> tickets)
        {
            return new Article
            {
                Brand = brand,
                Price = price,
                Quantity = quantity,
                CategoryId = categoryId,
                Tickets = tickets,
                Id = id,
                Name_Article = name_Article,

            };
        }*/
    }
    
}