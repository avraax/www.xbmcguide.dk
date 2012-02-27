using www.xbmcguide.dk.BusinessLogic.Interfaces;
using www.xbmcguide.dk.Core.Models.Entities;

namespace www.xbmcguide.dk.BusinessLogic
{
    public class ArticleLogic : IArticleLogic
    {
        private IArticleLogic _articleLogic;

        public ArticleLogic(IArticleLogic articleLogic)
        {
            _articleLogic = articleLogic;
        }

        public Article GetArticle(int id)
        {
            return _articleLogic.GetArticle(id);
        }
    }
}
