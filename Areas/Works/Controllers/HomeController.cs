using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingAreasApp.Areas.Works.Controllers
{
    [Area("Works")]
    public class HomeController : Controller
    {
        [Route("{area}/{controller}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
