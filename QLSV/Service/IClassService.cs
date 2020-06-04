using QLSV.Models;
using QLSV.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public interface IClassService
    {
        IEnumerable<Class> GetClasses();

        IEnumerable<Class> GetClassesBySchool_ID(int ID);

        //Test
        IEnumerable<ClassViewModel> GetClassViewModels();

        Class AddClass(Class class0);
        void DeleteClass(int ID);
        
    }
}