using QLSV.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetStudentsByClass_ID(int ID);
        Task<List<Student>> GetStudents_API();
        Task<string> AddStudent(Student student);
        Task<string> DeleteStudent(int ID);

        
    }

}