using Soulful.Models;
using Soulful.Services;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class EventController : Controller
    {
        EventService _eventService ;
        public EventController()
        {
            _eventService = new EventService();
        }
        // GET: Event
        public ActionResult Index()
        {
            return View(_eventService.GetSingerName());
        }

        public string GetData(int id)
        {
            var obj = _eventService.GetEventById(id);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            
            return json;
        }
    }
}