using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Exceptions;
using DataAccessLayer.Concrete;
using DtoLayer.ViewModel.Director;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IMBD.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DirectorController : ControllerBase
	{
		private readonly IDirectorService _directorService;
		private readonly IMapper _mapper;
		private readonly Context _context;

		public DirectorController(IDirectorService directorService, IMapper mapper, Context context)
		{
			_directorService = directorService;
			_mapper = mapper;
			_context = context;
		}
		[HttpGet]
		public IActionResult ListDirector()
		{
			var values = _directorService.TGetAll();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteFilm(int id)
		{
			var values = _directorService.TGetById(id);
			if (values is null)
			{
				throw new NotFoundException($"{id}li yönetmen bulunamadı.");
			}
			_directorService.TDelete(values);
			return Ok();
		}
		[HttpPost]
		public IActionResult CreateDirector(CreateDirectorVM createDirectorVM)
		{
			if (ModelState.IsValid)
			{
				 var director = _mapper.Map<Director>(createDirectorVM);
				_directorService.TInsert(director);
				return Ok();

			}
			return BadRequest();
		}
		[HttpPut]
		public IActionResult UpdateDirector(UpdateDirectorVM updateDirectorVM)
		{
			var values = _mapper.Map<Director>(updateDirectorVM);
			_directorService.TUpdate(values);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetDirectorWithFilm(int id)
		{
			var directorWithFilm = _context.Films.Where(x => x.DirectorId == id).ToList();
			return Ok(directorWithFilm);

		}
	}
}
