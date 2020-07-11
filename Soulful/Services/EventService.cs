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
        SoulfulContext _context;
        SoulfulRepository<Event> _eventRepo;
        SoulfulRepository<Singer> _singerRepo;
        public EventService()
        {
            _context = new SoulfulContext();
            _eventRepo = new SoulfulRepository<Event>(_context);
            _singerRepo = new SoulfulRepository<Singer>(_context);
        }
        public List<EventViewModel> GetSingerName()
        {
            var eventContext = from Event in _eventRepo.GetAll()
                               join Singer in _singerRepo.GetAll()
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
            var eventContext = from Event in _eventRepo.GetAll()
                               join Singer in _singerRepo.GetAll()
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