using API.Dal;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.Dto;

namespace UI.ViewComponents.Layout
{
    public class ServicePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult >InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7133/api/Service");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsonData = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultService>> (jsonData);

                var lastFourTestimonials = values.TakeLast(4).ToList();

                return View(lastFourTestimonials);

            }
                return View();
        }
    
    
    }
}
