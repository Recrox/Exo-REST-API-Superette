using Providers;
using Microsoft.EntityFrameworkCore;
using Providers.Mappings;
using Technocite.Auchan.Superette.Site.ViewModels.Mappings;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Buisness.Domains;
using Providers.Repositories;
using Data.Interfaces;

namespace Technocite.Auchan.Superette.Site
{
    public class Startup
    {
        /// <summary>
        /// Gets or sets the Configuration.
        /// </summary>
        public IConfiguration Configuration { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration parameters.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.
            services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            /*services.AddDbContext<WebSuperetteContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("Database")));*/

            services.AddDbContext<WebSuperetteContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("DatabaseTechnocite")));

            services.AddAutoMapper(typeof(SqlMapping), typeof(ApiMapping)); //ajouter de mes mappeurs

            services.AddTransient<IArticleDomain, ArticleDomain>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
