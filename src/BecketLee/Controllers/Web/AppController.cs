using System;
using System.Linq;
using BecketLee.Data;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;
        private BecketLeeRepository _repository;
        private readonly ILogger _logger;

        public AppController( IConfigurationRoot config, 
            BecketLeeRepository repository,
            ILogger<AppController> logger)
        {
            _config = config;
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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


    }
}
