using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.Dto;

namespace UI.ViewComponents.Layout
{
    public class MenüPartial  : ViewComponent
    {

        private readonly  IHttpClientFactory _httpClientFactory;

        public MenüPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7133/api/Food");
            if(responsemessage.IsSuccessStatusCode)
            {
                var jsonData = await responsemessage.Content.ReadAsStringAsync();   
                var values =   JsonConvert.DeserializeObject<List<ResultFood>>(jsonData); 
                return View(values);
            }
            return View();
        }

    }

}
