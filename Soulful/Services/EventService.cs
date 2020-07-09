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
            SoulfulRepository<Singer> singerRepostitory = new SoulfulRepository<Singer>(context);

            var eventContext = from Event in eventRepostitory.GetAll()
                               join Singer in singerRepostitory.GetAll()
                               on Event.Singer_id equals Singer.Singer_id 
                               select new EventViewModel
                               {
                                   Id = Event.Event_id,
                                   Name = Event.Name,
                                   Singer = Singer.Name,
                                   Date = Event.Datetime,
                                   Address = Event.Adress,
                                   Pic = Event.Pic,                                   
                                   About = Event.About
                               };

            return eventContext.ToList();
        }

        public EventViewModel GetEventById(int EventId)
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Event> eventRepostitory = new SoulfulRepository<Event>(context);
            SoulfulRepository<Singer> singerRepostitory = new SoulfulRepository<Singer>(context);
            var eventContext = from Event in eventRepostitory.GetAll()
                               join Singer in singerRepostitory.GetAll()
                               on Event.Singer_id equals Singer.Singer_id
                               select new EventViewModel
                               {
                                   Id = Event.Event_id,
                                   Name = Event.Name,
                                   Singer = Singer.Name,
                                   Date = Event.Datetime,
                                   Address = Event.Adress,
                                   Pic = Event.Pic,
                                   About = Event.About
                               };
            var EventById = eventContext.FirstOrDefault(x => x.Id == EventId);
            
            return EventById;
        }

    }
}