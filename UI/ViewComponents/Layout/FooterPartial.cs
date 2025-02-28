using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
    {
        return View();
    }
   
    }
}
