using DataAccessLayer.Concrete;
using DtoLayer.Dto;
using DtoLayer.ViewModel.Director;
using DtoLayer.ViewModel.SeriesVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace IMDB.Web.Controllers
{
	public class DirectorController : Controller
	{
		Context c = new Context();
		private readonly IHttpClientFactory _httpClientFactory;

		public DirectorController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7171/api/Director");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<DirectorDto>>(jsonData);
				return View(values);

			}
			return View();
		}
        public async Task<IActionResult> DeleteDirector(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7171/api/Director/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();


        }

        [HttpGet]
        public async Task<IActionResult> UpdateDirector(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7171/api/Director/{id}");           
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateDirectorVM>(jsonData);
                return View(values);
            }


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDirector(UpdateDirectorVM model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7171/api/Director/", stringContent);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateDirector()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDirector(CreateDirectorVM model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7171/api/Director/", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }



            return View();
        }
    }
}
