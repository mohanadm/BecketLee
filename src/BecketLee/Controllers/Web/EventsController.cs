using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Web
{
    public class EventsController : Controller
    {
        private readonly IEventRepository _repository;
        private readonly ILogger<EventsController> _logger;

        public EventsController( 
            IEventRepository repository,
            ILogger<EventsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }




        public IActionResult ManageEvents()
        {
            var data = _repository.Events();
            return View( data );
        }


        [HttpGet]
        [Authorize]
        public IActionResult EditEvent( string id )
        {
            var eventItem = _repository.GetEventById( id );                        
            return View( "EditEvent", eventItem );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEvent( string id, EventViewModel model )
        {
            await _repository.UpdateEventAsync( model );
            return RedirectToAction( "ManageEvents", "Events" );
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

        [HttpGet]
        public IActionResult DeleteEvent( string id )
        {
            var eventItem = _repository.GetEventById( id  );
            return PartialView( "_DeleteEvent", eventItem.Title );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEvent( string id, IFormCollection form )
        {
            if (!string.IsNullOrEmpty( id ))
            {
                var partnerBio = _repository.GetEventById( id );
                if (partnerBio != null)
                {
                    _repository.DeleteEvent( partnerBio );
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


    }
}