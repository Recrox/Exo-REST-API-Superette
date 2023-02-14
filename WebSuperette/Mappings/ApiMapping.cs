using AutoMapper;

namespace Technocite.Auchan.Superette.Site.ViewModels.Mappings
{
    public class ApiMapping : Profile
    {
        public ApiMapping()
        {
            this.CreateMap<Article, Core.Models.Article>().ReverseMap();
        }
    }
}