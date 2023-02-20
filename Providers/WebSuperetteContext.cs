using Microsoft.EntityFrameworkCore;
using Providers.Models;

namespace Providers
{
    public class WebSuperetteContext : DbContext
    {
        public WebSuperetteContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder
                .Entity<Article>()
                .HasMany(a => a.ArticleTickets)
                .WithOne()
                .HasForeignKey(at=>at.ArticleId)
                ;

            modelBuilder
                .Entity<Ticket>()
                .HasMany(a => a.ArticleTickets)
                .WithOne()
                .HasForeignKey(at => at.TicketId)
                ;*/

        }

        public DbSet<Article> Article { get; set; }
        public DbSet<CategoryArticle> CategoryArticle { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

        //public DbSet<ArticleTicket> ArticleTicket { get; set; }


    }
}
