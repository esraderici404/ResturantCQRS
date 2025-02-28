using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
