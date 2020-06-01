using Soulful.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            NewsService newsService = new NewsService();


            return View(newsService.GetAll());
        }
        

    }
}