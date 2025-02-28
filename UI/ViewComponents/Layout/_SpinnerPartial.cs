using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class _SpinnerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
  
    }
}
