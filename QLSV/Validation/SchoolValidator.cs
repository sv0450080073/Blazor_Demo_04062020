using FluentValidation;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Validation
{
    public class SchoolValidator : AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(scho => scho.ShoolName).NotEmpty().WithMessage("Không được để trống!");
        }
    }
}
