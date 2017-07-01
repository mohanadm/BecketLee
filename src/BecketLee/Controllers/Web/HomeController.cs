using System.Linq.Expressions;
using BecketLee.Data;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Web
{
    public class HomeController : BaseController 
    {
        private readonly IEventRepository _repository;
        private IConfigurationRoot _config;
        private readonly ILogger _logger;
        private PartnerMenuViewModel _menuModel;

        public HomeController( 
            IEventRepository repository,
            IPartnerRepository menuRepository,
            IConfigurationRoot config, 
            ILogger<HomeController> logger)
        {
            _repository = repository;
            _config = config;
            _logger = logger;
            _menuModel = new PartnerMenuViewModel(menuRepository);
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

        public override PartnerMenuViewModel MenuModel
        {
            get { return _menuModel; }
            set { _menuModel = value; }
        }
    }
}
