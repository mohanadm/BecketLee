using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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

            var selection = Mapper.Map<Event, EventViewModel>( result );
            selection.EventTypes = GetEventTypeSelectionList();

            return selection;
        }


        public IEnumerable<EventViewModel> Events()
        {
            var events = _context
                .Events
                .Include( e => e.EventType )
                .OrderByDescending( e => e.CreatedDate );

            var selectionList = GetEventTypeSelectionList();

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
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


        public IEnumerable<EventViewModel> GetEvents()
        {
            var events = _context
                .Events
                .Include( e=> e.EventType)
                .Where( e => e.EventType.EventTypeDescription == "Events" &&
                    e.CreatedDate > DateTime.Now.Subtract(new TimeSpan(365 * 2, 0, 0, 0)))
                .OrderByDescending(e => e.CreatedDate);
            var selectionList = GetEventTypeSelectionList();
            return events.Select( e =>
                new EventViewModel()
                {                    
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
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
                .OrderByDescending( e => e.CreatedDate );

            var selectionList = GetEventTypeSelectionList();

            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
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
                .OrderByDescending( e => e.CreatedDate );

            var selectionList = GetEventTypeSelectionList();
            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    EventHtml = e.EventHtml,
                    Title = e.Title,
                    EventType = e.EventType,
                    EventTypes = selectionList
                } );
        }

    }
}