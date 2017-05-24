using BecketLee.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Web
{
    public class AppController : Controller
    {
        private readonly IEventRepository _repository;
        private IConfigurationRoot _config;
        private readonly ILogger _logger;

        public AppController( 
            IEventRepository repository,
            IConfigurationRoot config, 
            ILogger<AppController> logger)
        {
            _repository = repository;
            _config = config;
            _logger = logger;
        }

        public IActionResult Index()
        {           
            return View( _repository.GetCurrentEvents());
        }


        public IActionResult OurServices()
       {
           return View();
       }

        public IActionResult FirmHistory()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult UnauthorizedView()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
