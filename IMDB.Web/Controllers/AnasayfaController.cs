using DataAccessLayer.Concrete;
using DtoLayer.Dto;
using Microsoft.AspNetCore.Mvc;

namespace IMDB.Web.Controllers
{
	public class AnasayfaController : Controller
	{
		private readonly Context _context;

		public AnasayfaController(Context context)
		{
			_context = context;
		}

		public IActionResult Index()
		{

			var totalDirector = _context.Directors.Count();
			var totalCategory = _context.Categories.Count();
			var totalFilm = _context.Films.Count();
			var totalSeries = _context.Serieses.Count();

			var viewModel = new CountDto
			{
				 Category = totalCategory,
				 Film = totalFilm,
				 Series = totalSeries,
				 Director=totalDirector

			};

			return View(viewModel);
		}
	}
}
