using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace www.xbmcguide.dk.Controllers
{
    public class MenuController : Controller
    {
        private XbmcGuideDataContext _xbmcDatabase;

        public ActionResult Menu()
        {
            _xbmcDatabase = new XbmcGuideDataContext();
            var model = _xbmcDatabase.Menus.ToList();

        return PartialView("~/Views/Shared/_Menu.cshtml", model);
        }
    }
}
