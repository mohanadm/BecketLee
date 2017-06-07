using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BecketLee.Data
{
    public class EventRepository : RepostitoryDataBase<EventViewModel>, IEventRepository
    {
        public EventRepository( BecketLeeContext context) 
            : base (context)
        {
            
        }

        public IEnumerable<EventViewModel> GetCurrentEvents()
        {
            var events = _context
                .Events
                .Include(e => e.EventType)                
                .OrderByDescending( e => e.StartDate )
                .Take( 20 );            

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    Title = e.Title,
                    EventType = e.EventType
                } );
        }

        public List<EventType> GetEventTypes()
        {
            return _context.EventTypes.ToList();
        }


        public EventViewModel GetEventById( string eventId )
        {
            var eventItem = _context.Events
                .Include( e => e.EventType )
                .FirstOrDefault( e => e.EventId.ToString() == eventId );

            var result = eventItem ?? new Event();

            return
                new EventViewModel()
                {
                    EventId = result.EventId,
                    CreatedDate = result.CreatedDate,
                    StartDate = result.StartDate,
                    EndDate = result.EndDate,
                    EventHtml = WebUtility.HtmlDecode( result.EventHtml ),
                    Title = result.Title,
                    EventType = result.EventType,
                    EventTypes = GetEventTypeSelectionList()
                };            
        }


        public IEnumerable<EventViewModel> Events()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .OrderByDescending( e => e.StartDate );

            var selectionList = GetEventTypeSelectionList();

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = WebUtility.HtmlDecode( e.EventHtml ),
                    Title = e.Title,
                    EventType = e.EventType,
                    EventTypes = selectionList
                } );
        }

        private List<SelectListItem> GetEventTypeSelectionList()
        {
            var selectionList = _context.EventTypes.Select( e => new SelectListItem
            {
                Text = e.EventTypeDescription,
                Value = e.EventTypeId.ToString()
            } ).ToList();
            return selectionList;
        }

        public async Task<EventViewModel> UpdateEventAsync( EventViewModel eventModel )
        {
            var eventItem = new Event();
            if (eventModel.EventId > 0)
                eventItem = _context.Events.FirstOrDefault( p => p.EventId == eventModel.EventId );

            eventItem.Title = eventModel.Title;
            eventItem.EventHtml = WebUtility.HtmlEncode( eventModel.EventHtml );
            eventItem.StartDate = eventModel.StartDate;
            eventItem.EndDate = eventModel.EndDate;
            eventItem.EventTypeId = eventModel.EventType.EventTypeId;
            
            if (eventItem.EventId > 0)
                _context.Update( eventItem );
            else
                _context.Add( eventItem );

            await _context.SaveChangesAsync( true );

            var newModel = new EventViewModel()
            {
                EventId = eventItem.EventId,
                Title = eventItem.Title,
                EventHtml = WebUtility.HtmlDecode( eventItem.EventHtml ),
                EventType = eventItem.EventType,
                StartDate = eventItem.StartDate,
                EndDate = eventItem.EndDate
            };
            return newModel;
        }



        public IEnumerable<EventViewModel> GetEvents()
        {
            var events = _context
                .Events
                .Include( e=> e.EventType)
                .Where( e => e.EventType.EventTypeDescription == "Events" &&
                    e.CreatedDate > DateTime.Now.Subtract(new TimeSpan(365 * 2, 0, 0, 0)))
                .OrderByDescending(e => e.StartDate);
            var selectionList = GetEventTypeSelectionList();
            return events.Select( e =>
                new EventViewModel()
                {                    
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = WebUtility.HtmlDecode( e.EventHtml ),
                    Title = e.Title,
                    EventType = e.EventType,
                    EventTypes = selectionList
                } );
        }


        public IEnumerable<EventViewModel> GetNews()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .Where( e => e.EventType.EventTypeDescription == "News" )
                .OrderByDescending( e => e.StartDate );

            var selectionList = GetEventTypeSelectionList();

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = WebUtility.HtmlDecode( e.EventHtml ),
                    Title = e.Title,
                    EventType = e.EventType,
                    EventTypes = selectionList
                } );
        }

        public IEnumerable<EventViewModel> GetPubs()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .Where( e => e.EventType.EventTypeDescription == "Pubs" )
                .OrderByDescending( e => e.StartDate );

            var selectionList = GetEventTypeSelectionList();
            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = WebUtility.HtmlDecode( e.EventHtml ),
                    Title = e.Title,
                    EventType = e.EventType,
                    EventTypes = selectionList
                } );
        }
        public IEnumerable<EventViewModel> GetCases()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .Where( e => e.EventType.EventTypeDescription == "Cases" )
                ;

            var selectionList = GetEventTypeSelectionList();
            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = WebUtility.HtmlDecode( e.EventHtml ),
                    Title = e.Title,
                    EventType = e.EventType,
                    EventTypes = selectionList
                } );
        }


        public void DeleteEvent( EventViewModel eventViewModel )
        {
            var eventItem = _context.Events.First( e => e.EventId == eventViewModel.EventId );
            _context.Events.Remove( eventItem );
            _context.SaveChanges();
        }

    }
}