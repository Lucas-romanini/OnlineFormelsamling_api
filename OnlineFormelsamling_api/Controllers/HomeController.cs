using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoOF;

namespace OnlineFormelsamling_api.Controllers
{
    public class HomeController : Controller
    {
        FormlerOFFac fof = new FormlerOFFac();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.test = "Testing testing testing";
                return View(fof.GetAll());
        }

        public ActionResult test()
        {
            return View();
        }

    }
}