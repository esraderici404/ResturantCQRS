using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
  
    }
}
