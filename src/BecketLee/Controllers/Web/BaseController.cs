using BecketLee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BecketLee.Controllers.Web
{
    public abstract class BaseController : Controller
    {
        public override void OnActionExecuting( ActionExecutingContext filterContext )
        {
            base.OnActionExecuting(filterContext);

            ViewBag.MenuModel = MenuModel;
        }

        public abstract PartnerMenuViewModel MenuModel { set; get; }

    }
}