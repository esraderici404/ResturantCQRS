using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
