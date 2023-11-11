using AutoMapper;
using DtoLayer.Dto;
using DtoLayer.ViewModel.CategoryVM;
using DtoLayer.ViewModel.Director;
using DtoLayer.ViewModel.FilmVM;
using DtoLayer.ViewModel.SeriesVM;
using EntityLayer.Concrete;

namespace IMBD.Api.AutoMapper
{
	public class AutoMapping : Profile
	{
		public AutoMapping()
		{
			CreateMap<FilmDto, Film>().ReverseMap();
			CreateMap<CreateFilmVM, Film>().ReverseMap();
			CreateMap<UpdateFilmVM, Film>().ReverseMap();
			CreateMap<Film,ResultFilmDto>().ReverseMap();
 



			CreateMap<CreateCategoryVM,Category>().ReverseMap();	
			CreateMap<UpdateCategoryVM,Category>().ReverseMap();	
			CreateMap<CategoryDto,Category>().ReverseMap();	

			CreateMap<CreateDirectorVM,Director>().ReverseMap();	
			CreateMap<UpdateDirectorVM,Director>().ReverseMap();	
			CreateMap<DirectorDto,Director>().ReverseMap();	

			CreateMap<CreateSeriesVM,Series>().ReverseMap();
			CreateMap<UpdateSeriesVM,Series>().ReverseMap();
			CreateMap<SeriesDto,Series>().ReverseMap();

		}
	}
}
