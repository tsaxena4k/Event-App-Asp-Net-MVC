using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Core.Entities;
using TSEventApp.Core.IRepository;
using TSEventApp.Infrastructure.Repository.Base;
using TSWebApp.Infrastructure.Data;

namespace TSEventApp.Infrastructure.Repository
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly EventContext _eventContext;

        public EventRepository(EventContext eventContext) : base(eventContext)
        {
            _eventContext = eventContext;
        }
        public async Task<int> CreateEvent(Event _event, string orgainser)
        {
            var newEvent = new Event()
            {
                Title = _event.Title,
                Date = _event.Date,
                Location = _event.Location,
                StartTime = _event.StartTime,
                Type = _event.Type,
                DurationInHours = _event.DurationInHours,
                InviteByEmail = _event.InviteByEmail,
                Description = _event.Description,
                OtherDetails = _event.OtherDetails,
                Organiser=orgainser
            };
            await _eventContext.Events.AddAsync(newEvent);
            await _eventContext.SaveChangesAsync();

            return newEvent.Id;
        }
        public async Task<IList<Event>> GetEvents()
        {
            //var allEvents = await _eventContext.Events.ToListAsync();
            //return DataSource();
            return await _eventContext.Events.OrderBy(x => x.Date).ToListAsync();
        }

        public async Task<Event> ViewDetails(int eventId)
        {
            //return DataSource().Where(x => x.Id == id).FirstOrDefault();
            return await _eventContext.Events.FindAsync(eventId);
        }
        
        public int UpdateEvent(Event _event)
        {
            _eventContext.Events.Update(_event);
            _eventContext.SaveChanges();
            return _event.Id;
        }

   
        public async Task<IList<Event>> MyEvents(string organiser)
        {
            var result = from _event in _eventContext.Events
                         where _event.Organiser == organiser
                         orderby _event.Date
                         select _event;
            return await result.ToListAsync();

        }

        public async Task<IList<Comment>> GetAllCommentByEventId(int eventId)
        {
            var result = await (from e in _eventContext.Events
                                join c in _eventContext.Comment on
                                e.Id equals c.EventId
                                where c.EventId == eventId
                                orderby c.timeStamp
                                select new Comment()
                                {
                                    EventId = eventId,
                                    comment = c.comment,
                                    timeStamp = c.timeStamp

                                }).ToListAsync();
            return result;
        }

    }
}
