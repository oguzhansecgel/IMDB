using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Exceptions;
using DataAccessLayer.Concrete;
using DtoLayer.ViewModel.CategoryVM;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IMBD.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;
		private readonly Context _context;
		public CategoryController(ICategoryService categoryService, IMapper mapper, Context context)
		{
			_categoryService = categoryService;
			_mapper = mapper;
			_context = context;
		}
		[HttpGet]
		public IActionResult ListCategory()
		{
			var values = _categoryService.TGetAll();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id)
		{
			var values = _categoryService.TGetById(id);
			if (values is null)
			{
				throw new NotFoundException($"{id}li kategori bulunamadı.");
			}
			_categoryService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryVM createCategoryVM)
		{
			if (ModelState.IsValid)
			{
				var category = _mapper.Map<Category>(createCategoryVM);
				_categoryService.TInsert(category);
				return Ok();
			}
			return BadRequest();
		}
		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryVM updateCategoryVM)
		{
			var values = _mapper.Map<Category>(updateCategoryVM);
			_categoryService.TUpdate(values);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetByIdCategory(int id)
		{
			var values = _categoryService.TGetById(id);
			return Ok(values);
		}
		[HttpGet("films/id")]
		public IActionResult GetCategoryWithFilm(int id) 
		{
			var categoryWithFilm = _context.Films.Where(x => x.CategoryId== id).ToList();
			return Ok(categoryWithFilm);
		}
	 
	}
}
