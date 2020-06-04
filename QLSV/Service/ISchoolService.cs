using QLSV.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public interface ISchoolService
    {
        IEnumerable<School>GetShools();
        School GetSchool(int ID);
        School AddSchool(School school);
        void DeleteSchool(int ID);
        void EditSchool(School school);
    }
}