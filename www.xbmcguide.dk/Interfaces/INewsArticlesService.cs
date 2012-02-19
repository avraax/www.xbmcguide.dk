using System.Collections.Generic;

namespace www.xbmcguide.dk.Interfaces
{
    public interface INewsArticlesService
    {
        bool CreateNewsArticle(TblNewsArticles tblNewsArticle);
        List<ViewNewsArticles> GetAllNewsArticles();
        List<ViewNewsArticlesFrontpage> GetAllNewsArticlesFrontpage();
        TblNewsArticles GetNewsArticle(int id);
        bool DeleteNewsArticle(int id);
        bool SaveNewsArticle(TblNewsArticles tblNewsArticle);
    }
}