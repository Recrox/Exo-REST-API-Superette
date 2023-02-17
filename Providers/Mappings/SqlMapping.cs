using AutoMapper;
using Providers.Models;

namespace Providers.Mappings
{
    public class SqlMapping : Profile
    {
        public SqlMapping()
        {
            this.CreateMap<Technocite.Auchan.Superette.Core.Models.Article, Article>()
                //.ForMember(a=> a.ArticleTickets.Select(a=>a.Ticket),m=>m.MapFrom(a2=> a2.Tickets))
                .ReverseMap()
                ;



            this.CreateMap<Technocite.Auchan.Superette.Core.Models.CategoryArticle, CategoryArticle>().ReverseMap();
            this.CreateMap<Technocite.Auchan.Superette.Core.Models.Ticket, Ticket>().ReverseMap();
            this.CreateMap<Technocite.Auchan.Superette.Core.Models.ArticleTicket, ArticleTicket>().ReverseMap();
        }
    }
}
