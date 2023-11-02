using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Exceptions;
using DtoLayer.ViewModel.FilmVM;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IMBD.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FilmController : ControllerBase
	{
		private readonly IFilmService _filmService;
		private readonly IMapper _mapper;
		public FilmController(IFilmService filmService, IMapper mapper)
		{
			_filmService = filmService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ListFilm()
		{
			var values = _filmService.TGetAll();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteFilm(int id)
		{
			var values = _filmService.TGetById(id);
			if(values is null )
			{
				throw new NotFoundException($"{id}li film bulunamadı.");
			}
			_filmService.TDelete(values);
			return Ok();
		}
		[HttpPost]
		public IActionResult CreateFilm(CreateFilmVM createFilmVM)
		{
			if(ModelState.IsValid)
			{
				var category = _mapper.Map<Film>(createFilmVM);
				_filmService.TInsert(category);
				return Ok();
			}
			return BadRequest();
		}
		[HttpPut]
		public IActionResult UpdateFilm(UpdateFilmVM updateFilmVM)
		{
			var values = _mapper.Map<Film>(updateFilmVM);
			_filmService.TUpdate(values);
			return Ok();
		}
	}
}
