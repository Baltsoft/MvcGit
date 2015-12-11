using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGit.Models;

namespace MvcGit.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var currentTime = DateTime.Now.ToString();
            var model = new IndexViewModel() { CurrentTime = currentTime };
            return View("Index", model);
        }

    }
}
