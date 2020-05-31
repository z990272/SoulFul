using Soulful.Models;
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
        private SoulfulContext context = new SoulfulContext();
        public ActionResult Index()
        {

            var AlbumDetail = from album in context.Album.ToList()
                              join singer in context.Singer.ToList()
                              on album.Singer_id equals singer.Singer_id
                              select album;
            
            return View(AlbumDetail);
        }


    }
}