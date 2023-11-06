using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Exceptions;
using DtoLayer.ViewModel.FilmVM;
using DtoLayer.ViewModel.SeriesVM;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMBD.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SeriesController : ControllerBase
	{
		private readonly ISeriesService _seriesService;
		private readonly IMapper _mapper;

		public SeriesController(ISeriesService seriesService, IMapper mapper)
		{
			_seriesService = seriesService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ListSeries()
		{
			var values = _seriesService.TGetAll();
			return Ok(values);
		}
        [HttpGet("{id}")]
        public IActionResult GetSeries(int id)
        {
            var values = _seriesService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
		public IActionResult DeleteSeries(int id)
		{
			var values = _seriesService.TGetById(id);
			if (values is null)
			{
				throw new NotFoundException($"{id}li dizi bulunamadı.");
			}
			_seriesService.TDelete(values);
			return Ok();
		}
		[HttpPost]
		public IActionResult CreateSeries(CreateSeriesVM createSeriesVM)
		{
			//if (ModelState.IsValid)
			//{
				var series = _mapper.Map<Series>(createSeriesVM);
				_seriesService.TInsert(series);
				return Ok();
			//}
			//return BadRequest();
		}

		[HttpPut]
		public IActionResult UpdateSeries(UpdateSeriesVM updateSeriesVM)
		{
			var values = _mapper.Map<Series>(updateSeriesVM);
			_seriesService.TUpdate(values);
			return Ok();
		}
	}
}
