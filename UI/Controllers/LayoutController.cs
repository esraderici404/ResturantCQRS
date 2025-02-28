using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult _Layout()
        {
            return View();
        }
    }
}
