using DtoLayer.ViewModel.Director;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator.Director
{
	public class UpdateDirectorValidator : AbstractValidator<UpdateDirectorVM>
	{
        public UpdateDirectorValidator()
        {
			RuleFor(x => x.DirectorName)
			   .NotEmpty().WithMessage("Yönetmen Adı Boş Geçilemez")
			   .MaximumLength(50).WithMessage("En fazla 50 karakterlik veri girişi yapınız.")
			   .MinimumLength(1).WithMessage("En az 1 karakterlik veri girişi yapınız.");
			RuleFor(x => x.DirectorSurname)
				.NotEmpty().WithMessage("Yönetmen Soyadı Boş Geçilemez")
				.MaximumLength(50).WithMessage("En fazla 50 karakterlik veri girişi yapınız.")
				.MinimumLength(1).WithMessage("En az 1 karakterlik veri girişi yapınız.");
		}
    }
}
