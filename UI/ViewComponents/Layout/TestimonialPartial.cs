using API.CQRS.Results.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.Dto;

namespace UI.ViewComponents.Layout
{
    public class TestimonialPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7133/api/Testimonial");
            if(responsemessage.IsSuccessStatusCode)
            {

                var jsonData = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonial>>(jsonData);

                // Sadece son 4 kaydı al
                var lastFourTestimonials = values.TakeLast(4).ToList();


                return View(lastFourTestimonials);
            }
            return View();
        }
  
   
    }
}
