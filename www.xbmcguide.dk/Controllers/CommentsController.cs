using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace www.xbmcguide.dk.Controllers
{
    public class CommentsController : Controller
    {
        private XbmcGuideDataContext _xbmcDatabase;

        public ActionResult Comments(int articleId)
        {
            //_xbmcDatabase = new XbmcGuideDataContext();
            //var model = _xbmcDatabase.GetNewsArticleComments(articleId).ToList();

            //return PartialView("~/Views/Shared/_Comments.cshtml", model);
            return null;
        }
    }
}
