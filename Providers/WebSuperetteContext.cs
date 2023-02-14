using Microsoft.EntityFrameworkCore;
using Providers.Models;

namespace Providers
{
    public class WebSuperetteContext : DbContext
    {
        public WebSuperetteContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Article> Article { get; set; }
        public DbSet<CategoryArticle> CategoryArticle { get; set; }

    }
}
