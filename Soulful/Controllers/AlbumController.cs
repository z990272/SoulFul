using Soulful.Repositories;
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
        private AlbumRepository _ar;
        public AlbumController()
        {
            _ar = new AlbumRepository();
        }
        // GET: Album
        //public ActionResult Albums()
        //{
        //    //AlbumModalService albumModalService = new AlbumModalService();
        //    // ViewData["Language"] = albumModalService.GetLanguage();
        //    //return View(albumModalService.GetModalinform());

        //    var language = _ar.getLanguages();
        //    ViewBag.Language = language;
        //    var album = _ar.getAlbums("All");
        //    ViewData["Album"] = album;
        //    return View();
        //}
        public ActionResult Albums(string lan)
        {
            var language = _ar.getLanguages();
            ViewBag.Language = language;
            var album = _ar.getAlbums(lan) ;
            ViewData["Album"] = album;
            return View();
        }
    }
}