﻿using AutoMapper;
using Data.Interfaces;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly WebSuperetteContext webSuperetteContext;
        private readonly IMapper mapper;

        public ArticleRepository(WebSuperetteContext webSuperetteContext,IMapper mapper)
        {
            this.webSuperetteContext = webSuperetteContext;
            this.mapper = mapper;
        }

        public void Add(Article article)
        {
            this.webSuperetteContext.Article.Add(this.mapper.Map<Models.Article>(article));
        }

        public IEnumerable<Article> GetAll()
        {
            return this.mapper.Map<IEnumerable<Article>>(this.webSuperetteContext.Article);
        }
    }
}
