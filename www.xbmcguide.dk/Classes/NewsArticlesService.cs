using System;
using System.Collections.Generic;
using System.Linq;
using www.xbmcguide.dk.Interfaces;

namespace www.xbmcguide.dk.Areas.NewsArticles.Classes
{
    public class NewsArticlesService : INewsArticlesService
    {
        private readonly XbmcGuideDataContext _xbmcDatabase;

        public NewsArticlesService()
        {
            _xbmcDatabase = new XbmcGuideDataContext();
        }

        public bool CreateNewsArticle(TblNewsArticles tblNewsArticle)
        {
            try
            {
                tblNewsArticle.CreatedDate = DateTime.Now;
                tblNewsArticle.ModifiedDate = DateTime.Now;
                tblNewsArticle.UserId = 1;
                _xbmcDatabase.TblNewsArticles.InsertOnSubmit(tblNewsArticle);
                _xbmcDatabase.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ViewNewsArticles> GetAllNewsArticles()
        {
            return _xbmcDatabase.ViewNewsArticles.ToList();
        }

        public List<ViewNewsArticlesFrontpage> GetAllNewsArticlesFrontpage()
        {
            return _xbmcDatabase.ViewNewsArticlesFrontpages.ToList();
        }

        public TblNewsArticles GetNewsArticle(int id)
        {
            return _xbmcDatabase.TblNewsArticles.Single(n => n.Id == id);
        }

        public bool DeleteNewsArticle(int id)
        {
            try
            {
                TblNewsArticles question = _xbmcDatabase.TblNewsArticles.Single(q => q.Id == id);
                _xbmcDatabase.TblNewsArticles.DeleteOnSubmit(question);
                _xbmcDatabase.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SaveNewsArticle(TblNewsArticles newsArticle)
        {
            try
            {
                TblNewsArticles tblNewsArticle = _xbmcDatabase.TblNewsArticles.Single(n => n.Id == newsArticle.Id);
                tblNewsArticle.Heading = newsArticle.Heading;
                tblNewsArticle.Body = newsArticle.Body;
                tblNewsArticle.Published = newsArticle.Published;
                tblNewsArticle.Frontpage = newsArticle.Frontpage;
                tblNewsArticle.ModifiedDate = DateTime.Now;
                _xbmcDatabase.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}