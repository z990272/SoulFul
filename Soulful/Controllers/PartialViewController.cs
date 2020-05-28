using Soulful.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: SimpleCard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SimpleCard()
        {
            List<AlbumCard> cards = new List<AlbumCard>
            {
                new AlbumCard{AlbumName="ASAP Ferg",AlbumBrief="Plain Jane",AlbumPhoto="a1.jpg"},
                new AlbumCard{AlbumName="ASAP Rocky",AlbumBrief="Second",AlbumPhoto="a2.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Three",AlbumPhoto="a3.jpg"},
                new AlbumCard{AlbumName="MayDay",AlbumBrief="Four",AlbumPhoto="a4.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Five",AlbumPhoto="a5.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Six",AlbumPhoto="a6.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Seven",AlbumPhoto="a7.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Eight",AlbumPhoto="a8.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Nine",AlbumPhoto="a9.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Ten",AlbumPhoto="a10.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Eleven",AlbumPhoto="a11.jpg"},
                new AlbumCard{AlbumName="Jay Chou",AlbumBrief="Twelve",AlbumPhoto="a12.jpg"},
            };
            return View(cards);
        }
    }
}