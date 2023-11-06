using DataAccessLayer.Concrete;
using DtoLayer.Dto;
using DtoLayer.ViewModel.SeriesVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace IMDB.Web.Controllers
{
    public class SeriesController : Controller
    {
        Context c = new Context();

        private readonly IHttpClientFactory _httpClientFactory;
        
        public SeriesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7171/api/Series");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SeriesDto>>(jsonData);
                return View(values);
            
            }
            return View();
        }
        public async Task<IActionResult> DeleteSeries(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7171/api/Series/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();


        }

        [HttpGet]
        public async Task<IActionResult> UpdateSeries(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7171/api/Series/{id}");
            List<SelectListItem> value = (from x in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }
                              ).ToList();
            ViewBag.v1 = value;
            List<SelectListItem> value2 = (from x in c.Directors.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.DirectorName +" "+ x.DirectorSurname,
                                              
                                              Value = x.DirectorID.ToString()
                                          }
                             ).ToList();
            ViewBag.v2 = value2;
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateSeriesVM>(jsonData);
                return View(values);
            }


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSeries(UpdateSeriesVM model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7171/api/Series/", stringContent);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }


        [HttpGet]
        public IActionResult CreateSeries()
        {
            if (ModelState.IsValid)
            {
                List<SelectListItem> value = (from x in c.Categories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryId.ToString()
                                              }
                             ).ToList();
                ViewBag.v1 = value;
                List<SelectListItem> value2 = (from x in c.Directors.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.DirectorName + " " + x.DirectorSurname,

                                                   Value = x.DirectorID.ToString()
                                               }
                                 ).ToList();
                ViewBag.v2 = value2;
                return View();
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSeries(CreateSeriesVM model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7171/api/Series/", stringContent);



                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }



            return View();
        }
    }
}
