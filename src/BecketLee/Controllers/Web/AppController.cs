using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BecketLee.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;

        public AppController( IConfigurationRoot config )
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Services()
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


    }
}
