using QLSV.Data;
using QLSV.Models;
using QLSV.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace QLSV.Service
{
    public class ClassService : IClassService
    {
        private readonly QLSVDbContext _qLSVDbContext;

        public ClassService(QLSVDbContext qLSVDbContext)
        {
            _qLSVDbContext = qLSVDbContext;
        }

        public IEnumerable<Class> GetClassesBySchool_ID(int ID)
        {
            return _qLSVDbContext.Classes.Where(x => x.School_ID == ID).ToList();
        }

        public IEnumerable<Class> GetClasses()
        {
            return _qLSVDbContext.Classes.ToList();
        }

        public IEnumerable<ClassViewModel> GetClassViewModels()
        {
            var Result = (from C in _qLSVDbContext.Classes
                          join S in _qLSVDbContext.Schools
                          on C.School_ID equals S.ID
                          select new ClassViewModel
                          {
                              ID = C.ID,
                              ClassName = C.ClassName,
                              SchoolName = S.ShoolName
                          }).ToList();
            return Result;
        }

        public Class AddClass(Class class0)
        {
            var Result = _qLSVDbContext.Add(class0);
            _qLSVDbContext.SaveChanges();
            return Result.Entity;
        }

        public void DeleteClass(int ID)
        {
            var ClassToDelete = _qLSVDbContext.Classes.Find(ID);
            _qLSVDbContext.Remove(ClassToDelete);
            _qLSVDbContext.SaveChanges();
        }
    }
}