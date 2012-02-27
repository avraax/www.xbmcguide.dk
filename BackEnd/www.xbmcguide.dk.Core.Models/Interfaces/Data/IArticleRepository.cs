using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using www.xbmcguide.dk.Core.Models.Entities;

namespace www.xbmcguide.dk.Core.Models.Interfaces.Data
{
    public interface IArticleRepository
    {
        List<Article> GetSearchResult(string q);
        List<Article> GetAllArticles();
        List<Article> GetAllArticlesForFrontpage();
        Article Get(int id);
        void Save(Article article);
        void Delete(Article article);
    }
}
