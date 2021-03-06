﻿using Soulful.Models;
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
        private AlbumDapperService _ar;
        public AlbumController()
        {
            _ar = new AlbumDapperService();
        }
      
        public ActionResult Albums(string lan, string search)
        {
            var language = _ar.getLanguages();
            ViewBag.Language = language;
            var album = _ar.getAlbums(lan);
            ViewData["Album"] = album;

            return View();
        }
        [HttpPost]
        public ActionResult Albums(string search)
        {
            var language = _ar.getLanguages();
            ViewBag.Language = language;
            var data = _ar.searchAlbums();
            var result = data.Where(x => x.Album_Name.Contains(search) || x.Name.Contains(search));
            ViewData["Album"] = result;
            return View();
        }
        [HttpPost]
        public ActionResult OnclickAlbums(string search)
        {
            var data = _ar.searchAlbums();
            var result = data.Where(x => x.Album_Name.Contains(search) || x.Name.Contains(search));
            return PartialView("AlbumPartialView", result);
        }

        public void HitClick(int id)
        {
            ProductService service = new ProductService();
            service.UpdateHit(id);
        }

        public string AlbumClick(int id)
        {
            var album = _ar.searchAlbums();
            var obj= album.FirstOrDefault(x => x.Album_id == id);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            return json;
        }
    }
}