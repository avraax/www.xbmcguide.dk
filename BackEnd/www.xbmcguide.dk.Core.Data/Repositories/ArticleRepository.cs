using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using www.xbmcguide.dk.NHibernate;
using www.xbmcguide.dk.Core.Models.Entities;
using www.xbmcguide.dk.Core.Models.Interfaces.Data;

namespace www.xbmcguide.dk.Core.Data.Repositories
{
    public class ArticleRepository: IArticleRepository
    {
        public List<Article> GetSearchResult(string q)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAllArticles()
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAllArticlesForFrontpage()
        {
            throw new NotImplementedException();
        }

        public Article Get(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Article>(id);
        }

        public void Save(Article newsArticle)
        {
            throw new NotImplementedException();
        }

        public void Delete(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
