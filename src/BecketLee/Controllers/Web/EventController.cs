using BecketLee.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Web
{
    public class EventController : Controller
    {
        private readonly IEventRepository _repository;
        private readonly ILogger<EventController> _logger;

        public EventController( 
            IEventRepository repository,
            ILogger<EventController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Events()
        {
            var data = _repository.GetEvents();
            return View(data);
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