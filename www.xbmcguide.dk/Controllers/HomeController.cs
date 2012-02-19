using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.xbmcguide.dk.Areas.NewsArticles.Classes;
using www.xbmcguide.dk.Interfaces;

namespace www.xbmcguide.dk.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsArticlesService _newsArticlesService;

        public HomeController()
        {
            _newsArticlesService = new NewsArticlesService();
        }
        public ActionResult Index()
        {
            ViewBag.Message = "";

            List<ViewNewsArticlesFrontpage> viewNewsArticlesFrontpage = _newsArticlesService.GetAllNewsArticlesFrontpage().OrderByDescending(a => a.CreatedDate).ToList();
            return View(viewNewsArticlesFrontpage);
        }

        ////
        //// GET: /NewsArticles/NewsArticles/Details/5

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //
        // GET: /NewsArticles/NewsArticles/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NewsArticles/NewsArticles/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(TblNewsArticles newsArticle)
        {
            return _newsArticlesService.CreateNewsArticle(newsArticle) ? (ActionResult)RedirectToAction("Index") : View();
        }

        //
        // GET: /NewsArticles/NewsArticles/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            TblNewsArticles question = _newsArticlesService.GetNewsArticle(id);
            return View(question);
        }

        //
        // POST: /NewsArticles/NewsArticles/Edit/5

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(TblNewsArticles newsArticle)
        {
            return _newsArticlesService.SaveNewsArticle(newsArticle) ? (ActionResult)RedirectToAction("Index") : View();
        }

        //
        // GET: /NewsArticles/NewsArticles/Delete/5

        public ActionResult Delete(int id)
        {
            TblNewsArticles newsArticle = _newsArticlesService.GetNewsArticle(id);
            return View(newsArticle);
        }

        //
        // POST: /NewsArticles/NewsArticles/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            return _newsArticlesService.DeleteNewsArticle(id) ? (ActionResult)RedirectToAction("Index") : View();
        }

        public ActionResult Details(int id, string articleHeading)
        {
            TblNewsArticles newsArticle = _newsArticlesService.GetNewsArticle(id);
            return View(newsArticle);
        }
    }
}
