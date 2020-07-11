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
        ProductService _productService;
        public HomeController()
        {
            _productService = new ProductService();
        }
        public ActionResult Index()
        {

            ViewData["WeekHits"] = _productService.GetWeekHits();
            ViewData["MonthHits"] = _productService.GetMonthHits();
            ViewData["TotalHits"] = _productService.GetTotalHits();

            return View(_productService.GetSingerName());
        }

        public string GetData(int id)
        {
            return _productService.GetVideoById(id);
        }

    }
}