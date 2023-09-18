using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kateqoriya adını daxil edin");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kateqoriya detalını daxil edin");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kateqoriya adını maksimum 50 xarakter daxil edin");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kateqoriya detalını minimum 2 xarakter daxil edin");
        }
    }
}
