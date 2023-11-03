using DtoLayer.ViewModel.CategoryVM;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator.Category
{
	public class CreateCategoryValidator : AbstractValidator<CreateCategoryVM>
	{
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez.").MaximumLength(50).WithMessage("En fazla 50 karakterlik veri girişi yapınız.").MinimumLength(1).WithMessage("en az bir karakterlik veri girişi yapınız.");
        }
    }
}
