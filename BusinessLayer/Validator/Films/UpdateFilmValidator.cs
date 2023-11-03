using DtoLayer.ViewModel.FilmVM;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator.Films
{
	public class UpdateFilmValidator : AbstractValidator<UpdateFilmVM>
	{
		public UpdateFilmValidator()
		{
			RuleFor(x => x.FilmName).
				NotEmpty().WithMessage("Film Adı Boş Geçilemez").
				MaximumLength(100).WithMessage("Maksimum 100 karakterlik veri girişi yapınız.").
				MinimumLength(1).WithMessage("en az 1 karakterlik veri girişi yapınız.");
			RuleFor(x => x.FilmYear).NotEmpty().WithMessage("Film Yılı Boş Geçilemez");
			RuleFor(x => x.FilmDescription).NotEmpty().WithMessage("Film Açıklaması Boş Geçilemez").MinimumLength(1).WithMessage("En az 1 karakter veri girişi yapınız");

		}
	}
}
