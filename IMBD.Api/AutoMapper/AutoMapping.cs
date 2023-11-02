using AutoMapper;
using DtoLayer.Dto;
using DtoLayer.ViewModel.CategoryVM;
using DtoLayer.ViewModel.FilmVM;
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

			CreateMap<CreateCategoryVM,Category>().ReverseMap();	
			CreateMap<UpdateCategoryVM,Category>().ReverseMap();	
		}
	}
}
