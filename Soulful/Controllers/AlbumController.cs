using Soulful.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Albums()
        {
            ProductService productService = new ProductService();

            return View(productService.GetSingerName());
        }
    }
}