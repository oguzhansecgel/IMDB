using Microsoft.AspNetCore.Mvc;

namespace IMDB.Web.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
