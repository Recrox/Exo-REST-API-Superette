using AutoMapper;
using Providers.Models;

namespace Providers.Mappings
{
    public class SqlMapping : Profile
    {
        public SqlMapping()
        {
            this.CreateMap<Technocite.Auchan.Superette.Core.Models.Article, Article>().ReverseMap();
            this.CreateMap<Technocite.Auchan.Superette.Core.Models.CategoryArticle, CategoryArticle>().ReverseMap();
        }
    }
}
