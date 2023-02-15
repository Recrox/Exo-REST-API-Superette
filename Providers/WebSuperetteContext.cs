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
            modelBuilder
                .Entity<Article>()
                .HasMany(a => a.Tickets)
                .WithMany(p => p.Articles);

                //.UsingEntity(j => j.ToTable("PostTags"));
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<CategoryArticle> CategoryArticle { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

    }
}
