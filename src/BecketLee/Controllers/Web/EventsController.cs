using BecketLee.Data;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
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


        public IActionResult Events()
        {
            var data = _repository.GetEvents();
            return View( data );
        }

        public IActionResult News()
        {
            var data = _repository.GetNews();
            return View( data );
        }

        public IActionResult Pubs()
        {
            var data = _repository.GetPubs();
            return View( data );
        }



    }
}