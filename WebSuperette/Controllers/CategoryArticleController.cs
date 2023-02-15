using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Technocite.Auchan.Superette.Buisness.Interfaces;
using Technocite.Auchan.Superette.Site.ViewModels;

namespace Technocite.Auchan.Superette.Site.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryArticleController : ControllerBase
    {
        private readonly ICategoryArticleDomain categoryArticleDomain;
        private readonly IMapper mapper;

        public CategoryArticleController(ICategoryArticleDomain categoryArticleDomain, IMapper mapper)
        {
            this.categoryArticleDomain = categoryArticleDomain;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var CategoryArticle =  this.categoryArticleDomain.GetAll();

            return this.Ok(this.mapper.Map<IEnumerable<CategoryArticle>>(CategoryArticle));
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CategoryArticle categoryArticle) 
        {
            await this.categoryArticleDomain.AddAsync(this.mapper.Map<Core.Models.CategoryArticle>(categoryArticle));
            return this.Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await this.categoryArticleDomain.RemoveByIdAsync(id);
            return this.Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(CategoryArticle categoryArticle) 
        {
            try
            {
                await this.categoryArticleDomain.UpdateAsync(this.mapper.Map<Core.Models.CategoryArticle>(categoryArticle));
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
