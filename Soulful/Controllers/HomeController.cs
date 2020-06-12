using Soulful.Models;
using Soulful.Repositories;
using Soulful.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ProductService productService = new ProductService();

            ViewData["WeekHits"] = productService.GetWeekHits();
            ViewData["MonthHits"] = productService.GetMonthHits();
            ViewData["TotalHits"] = productService.GetTotalHits();

            return View(productService.GetSingerName());
        }  

        

    }
}