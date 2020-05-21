using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class RankController : Controller
    {
        // GET: Rank
        public ActionResult Index()
        {
            //資料庫抓出排行前10的建立models
            return View();
        }
    }
}