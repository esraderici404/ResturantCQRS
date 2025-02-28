using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class AboutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    
    }
}
