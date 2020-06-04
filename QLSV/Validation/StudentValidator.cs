using FluentValidation;
using QLSV.Models;
using QLSV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Validation
{
    public class StudentValidator : AbstractValidator<Student>
    {
       public StudentValidator()
        {
            RuleFor(stu => stu.Class_ID).NotEmpty().WithMessage("Không được để trống!");
            RuleFor(stu => stu.StudentName).NotEmpty()
                                       .WithMessage("Không được để trống!");
          
            
        }

    }
}
