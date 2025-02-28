using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
