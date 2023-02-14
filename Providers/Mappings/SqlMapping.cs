using AutoMapper;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Mappings
{
    public class SqlMapping : Profile
    {
        public SqlMapping()
        {
            this.CreateMap<Article, Models.Article>().ReverseMap();
        }
    }
}
