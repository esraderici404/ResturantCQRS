using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
