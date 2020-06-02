using Soulful.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            EventService eventService = new EventService();


            return View(eventService.GetSingerName());
        }
    }
}