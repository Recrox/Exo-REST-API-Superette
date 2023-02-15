using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Site.ViewModels;

namespace Technocite.Auchan.Superette.Site.Controllers
{
    [Route("api/[controller]/[action]")]
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
        [HttpGet]
        public IActionResult GetAll()
        {
            var articles =  this.articleDomain.GetAll();

            return this.Ok(this.mapper.Map<IEnumerable<Article>>(articles));
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(Article article) 
        {
            try
            {
                await this.articleDomain.AddAsync(this.mapper.Map<Technocite.Auchan.Superette.Core.Models.Article>(article));
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await this.articleDomain.RemoveByIdAsync(id);
            return this.Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync(Article article) 
        {
            try
            {
                await this.articleDomain.UpdateAsync(this.mapper.Map<Technocite.Auchan.Superette.Core.Models.Article>(article));
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
