using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BecketLee.Data
{
    public class EventRepository : RepostitoryDataBase<EventViewModel>, IEventRepository
    {
        private List<EventType> _eventTypeList;

        public EventRepository( BecketLeeDbContext context )
            : base( context )
        {
            _eventTypeList = GetEventTypes();
        }

        public IEnumerable<EventViewModel> GetCurrentEvents()
        {
            var events = _context
                .Events
                .OrderByDescending( e => e.StartDate )
                .Take( 20 );
                 
            return events.Select( e =>
                new EventViewModel()
                {
                    EventId = e.EventId,
                    CreatedDate = e.CreatedDate,
                    StartDate = e.StartDate,
                    Title = e.Title,
                    EventTypeId = e.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription( e.EventTypeId ),
                } );
        }

        public List<EventType> GetEventTypes()
        {
            return _context.EventTypes.ToList();
        }


        public EventViewModel GetEventById( string eventId )
        {
            var eventItem = _context.Events
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
                    EventTypeId = result.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription( result.EventTypeId ),
                    EventTypes = GetEventTypeSelectionList()
                };
        }


        public IEnumerable<EventViewModel> Events( string searchTerm, int eventTypeId )
        {
            var events = _context
                .Events
                .Where( e => (searchTerm == null || e.Title.Contains( searchTerm )) &&
                    (eventTypeId == -1 || e.EventTypeId == eventTypeId) )
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
                    EventTypeId = e.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription( e.EventTypeId ),
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
                eventItem = _context.Events.FirstOrDefault(p => p.EventId == eventModel.EventId);

            eventItem.Title = eventModel.Title;
            eventItem.EventHtml = WebUtility.HtmlEncode( eventModel.EventHtml );
            eventItem.StartDate = eventModel.StartDate;
            eventItem.EndDate = eventModel.EndDate;
            eventItem.EventTypeId = eventModel.EventTypeId;

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
                EventTypeId = eventItem.EventTypeId,
                EventTypeDescription = GetEventTypeDescription( eventItem.EventTypeId ),
                StartDate = eventItem.StartDate,
                EndDate = eventItem.EndDate
            };
            return newModel;
        }



        public IEnumerable<EventViewModel> GetEvents()
        {
            var events = _context
                .Events
                .Where( e => e.EventTypeId == (int)EventEnum.Events &&
                    e.CreatedDate > DateTime.Now.Subtract( new TimeSpan( 365 * 2, 0, 0, 0 ) ) )
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
                    EventTypeId = e.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription( e.EventTypeId ),
                    EventTypes = selectionList
                } ).OrderByDescending( e => e.StartDate );
        }

        private string GetEventTypeDescription(int eventTypeId)
        {
            var eventType = _eventTypeList
                .FirstOrDefault(et => et.EventTypeId == eventTypeId);
            return eventType != null ? eventType.EventTypeDescription : ""; 
        }


        public IEnumerable<EventViewModel> GetNews()
        {
            var events = _context
                .Events
                .Where( e => e.EventTypeId == (int)EventEnum.News );

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
                    EventTypeId = e.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription(e.EventTypeId),
                    EventTypes = selectionList
                } ).OrderByDescending( e => e.StartDate );
        }

        public IEnumerable<EventViewModel> GetPubs()
        {
            var events = _context
                .Events
                .Where( e => e.EventTypeId == (int)EventEnum.Pubs )
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
                    EventTypeId = e.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription( e.EventTypeId ),
                    EventTypes = selectionList
                } ).OrderByDescending( e => e.StartDate );
        }
        public IEnumerable<EventViewModel> GetCases()
        {
            var events = _context
                .Events
                .Where( e => e.EventTypeId == (int)EventEnum.Cases )
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
                    EventTypeId = e.EventTypeId,
                    EventTypeDescription = GetEventTypeDescription( e.EventTypeId ),
                    EventTypes = selectionList
                } ).OrderByDescending( e => e.StartDate );
        }


        public void DeleteEvent( EventViewModel eventViewModel )
        {
            var eventItem = _context.Events.First( e => e.EventId == eventViewModel.EventId );
            _context.Events.Remove( eventItem );
            _context.SaveChanges();
        }

    }

    public enum EventEnum : int
    {
        News = 1,
        Events = 2,
        Pubs = 3,
        Cases = 4
    }
}