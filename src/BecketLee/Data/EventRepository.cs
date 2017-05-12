using System;
using System.Collections.Generic;
using System.Linq;
using BecketLee.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BecketLee.Data
{
    public class EventRepository : RepostitoryDataBase<EventViewModel>, IEventRepository
    {
        public EventRepository( BecketLeeContext context) 
            : base (context)
        {
            
        }



        public IEnumerable<EventViewModel> GetEvents()
        {
            var events = _context
                .Events
                .Include( e=> e.EventType)
                .Where( e => e.EventType.EventTypeDescription == "Events" &&
                    e.CreatedDate > DateTime.Now.Subtract(new TimeSpan(365 * 2, 0, 0, 0)))
                .OrderByDescending(e => e.CreatedDate);

            return events.Select( e =>
                new EventViewModel()
                {                    
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
                    Title = e.Title,
                    EventType = e.EventType
                } );
        }


        public IEnumerable<EventViewModel> GetNews()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .Where( e => e.EventType.EventTypeDescription == "News" )
                .OrderByDescending( e => e.CreatedDate );

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
                    Title = e.Title,
                    EventType = e.EventType
                } );
        }

        public IEnumerable<EventViewModel> GetPubs()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .Where( e => e.EventType.EventTypeDescription == "Pubs" )
                .OrderByDescending( e => e.CreatedDate );

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
                    Title = e.Title,
                    EventType = e.EventType
                } );
        }

    }
}