using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Web
{
    public class EventsController : BaseController
    {
        private readonly IEventRepository _repository;
        private readonly ILogger<EventsController> _logger;
        private PartnerMenuViewModel _menuModel;

        public EventsController( 
            IPartnerRepository menuRepository,
            IEventRepository repository,
            ILogger<EventsController> logger)
        {
            _repository = repository;
            _logger = logger;
            _menuModel = new PartnerMenuViewModel(menuRepository);
        }




        public IActionResult ManageEvents(string searchTerm = null, int eventTypeId = -1)
        {
            var model = GetEventsViewModel( searchTerm, eventTypeId, -1 );
            return View( model );
        }

        private EventsViewModel GetEventsViewModel( string searchTerm, int eventTypeId, int deleteId )
        {
            var model = new EventsViewModel
            {
                Events = _repository.Events( searchTerm, eventTypeId )
            };
            if( deleteId > 0 )
            {
                var deleteEvent = model.Events.FirstOrDefault( e => e.EventId == deleteId );
                if( deleteEvent != null )
                {
                    var delModel = new DeletionModel()
                    {
                        Controller = "Events",
                        Action = "DeleteEvent",
                        DeleteId = deleteId,
                        Heading = "Confirm Deletion",
                        Item = "event",
                        Title = deleteEvent.Title
                    };
                    model.DeletionModel = delModel;
                }
            }
            return model;
        }

        public IActionResult ConfirmEventDeletion( int id )
        {
            var model = GetEventsViewModel( null, -1, id );
            return View( "ManageEvents", model );
        }


        [HttpGet]
        [Authorize]
        public IActionResult EditEvent( string id )
        {
            if (!User.IsInRole( "Administrator" ) &&
                !User.IsInRole( "EventEditor" ))
            {
                return RedirectToAction( "UnauthorizedView", "Home" );
            }

            var eventItem = _repository.GetEventById( id );                        
            return View( "EditEvent", eventItem );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEvent( string id, EventViewModel model )
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateEventAsync(model);
                return RedirectToAction( "ManageEvents", "Events" );
            }

            var eventItem = _repository.GetEventById( id );
            eventItem.Title = model.Title;
            eventItem.EventHtml = model.EventHtml;
            eventItem.StartDate = model.StartDate;
            eventItem.EndDate = model.EndDate;
            eventItem.EventTypeId = model.EventTypeId;
            return View( "EditEvent", eventItem );
        }


        public IActionResult Events(string id)
        {           
            var events = new EventsViewModel();
            EventViewModel selectedEvent ;
            events.Events = _repository.GetEvents();


            if( !string.IsNullOrEmpty( id ) )
                selectedEvent = _repository.GetEventById( id );
            else
                selectedEvent = events.Events.FirstOrDefault();

            events.SelectedTitle = selectedEvent.Title;
            events.SelectedEventHtml = WebUtility.HtmlDecode( selectedEvent.EventHtml );

            return View( events );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEvent( string deleteId )
        {
            if (!string.IsNullOrEmpty( deleteId ))
            {
                var webEvent = _repository.GetEventById( deleteId );
                if (webEvent != null)
                {
                    _repository.DeleteEvent( webEvent );
                }
            }
            return RedirectToAction( "ManageEvents" );
        }


        public IActionResult News( string id )
        {
            var events = new EventsViewModel();
            EventViewModel selectedEvent;
            events.Events = _repository.GetNews();


            if (!string.IsNullOrEmpty( id ))
                selectedEvent = _repository.GetEventById( id );
            else
                selectedEvent = events.Events.FirstOrDefault();

            events.SelectedTitle = selectedEvent.Title;
            events.SelectedEventHtml = WebUtility.HtmlDecode( selectedEvent.EventHtml );

            return View( events );
        }


        public IActionResult Pubs( string id )
        {
            var events = new EventsViewModel();
            EventViewModel selectedEvent;
            events.Events = _repository.GetPubs();


            if (!string.IsNullOrEmpty( id ))
                selectedEvent = _repository.GetEventById( id );
            else
                selectedEvent = events.Events.FirstOrDefault();

            events.SelectedTitle = selectedEvent.Title;
            events.SelectedEventHtml = WebUtility.HtmlDecode( selectedEvent.EventHtml );

            return View( events );
        }

        public IActionResult Cases( string id )
        {
            var events = new EventsViewModel();
            EventViewModel selectedEvent;
            events.Events = _repository.GetCases();


            if (!string.IsNullOrEmpty( id ))
                selectedEvent = _repository.GetEventById( id );
            else
                selectedEvent = events.Events.FirstOrDefault();

            events.SelectedTitle = selectedEvent.Title;
            events.SelectedEventHtml = WebUtility.HtmlDecode( selectedEvent.EventHtml );

            return View( events );
        }


        public override PartnerMenuViewModel MenuModel
        {
            get { return _menuModel; }
            set { _menuModel = value; }
        }
    }
}