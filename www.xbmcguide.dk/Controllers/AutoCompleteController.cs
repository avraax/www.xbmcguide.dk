using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.xbmcguide.dk.Areas.AutoComplete.Classes;
using www.xbmcguide.dk.Areas.NewsArticles.Classes;

namespace www.xbmcguide.dk.Controllers
{
    public class AutoCompleteController : Controller
    {
        public ActionResult SearchResult(string q)
        {
            var searchAutoComplete = new AutoCompleteService();
            var searchResult = searchAutoComplete.GetSearchResult(q);

            return Json(searchResult);
        }
    }
}
