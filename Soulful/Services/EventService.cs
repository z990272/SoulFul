using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.Services
{
    public class EventService
    {
        public List<EventViewModel> GetSingerName()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Event> eventRepostitory = new SoulfulRepository<Event>(context);

            var eventContext = from Event in eventRepostitory.GetAll()
                               select new EventViewModel
                               {
                                   Name = Event.Name,
                                   Date = Event.Datetime,
                                   Pic = Event.Pic
                               };

            return eventContext.ToList();
        }
    }
}