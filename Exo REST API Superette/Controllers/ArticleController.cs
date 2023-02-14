using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Site.ViewModels;

namespace Exo_REST_API_Superette.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleDomain articleDomain;
        private readonly IMapper mapper;

        public ArticleController(IArticleDomain articleDomain, IMapper mapper)
        {
            this.articleDomain = articleDomain;
            this.mapper = mapper;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var articles =  this.articleDomain.GetAll();

            return this.Ok(this.mapper.Map<IEnumerable<Article>>(articles));
        }
    }
}
