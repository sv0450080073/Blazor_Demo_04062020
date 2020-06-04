using FluentValidation;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Validation
{
    public class ClassValidator : AbstractValidator<Class>
    {
        public  ClassValidator()
        {
            RuleFor(clas => clas.ClassName).NotEmpty().WithMessage("Không được để trống !");
            RuleFor(clas => clas.School_ID).NotEmpty().WithMessage("Trường học không được để trống !");
        }
    }
}
