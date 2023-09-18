using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("* Blog bashligini doldurun");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("* Blog contentini doldurun");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("* Blog sheklini doldurun");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("* 150 xarakterden az melumat doldurun");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("* 4 xarakterden cox melumat doldurun");

        }
    }
}
