using Microsoft.AspNetCore.Mvc;
using QLSV.Data;
using QLSV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public class StudentService : IStudentService
    {
        private readonly QLSVDbContext _qLSVDbContext;
        private readonly HttpClient _httpClient;

        public StudentService(QLSVDbContext qLSVDbContext,HttpClient httpClient)
        {
            _qLSVDbContext = qLSVDbContext;
            _httpClient = httpClient;
        }

        public async Task<string> AddStudent(Student student)
        {
            if (student.StudentName != "" && student.Class_ID > 0)
            {
              await _httpClient.PostAsJsonAsync( "/api/Student/", student);
            }
            else
            {
                return null;
            }
            return "ok" ;

        }

        public async Task<string> DeleteStudent(int ID)
        {
            if(ID<0)
            {
                return null;
            }
           /* return await _httpClient.DeleteAsync("api/student/" + ID);*/
            await _httpClient.DeleteAsync("api/Student/"+ID);
            return "ok";

        }

        public IEnumerable<Student> GetStudents()
        {
            return _qLSVDbContext.Students.ToList();
        }

        public IEnumerable<Student> GetStudentsByClass_ID(int Class_ID)
        {
            return _qLSVDbContext.Students.Where(x => x.Class_ID == Class_ID).ToList();
        }

      
        public  async Task<List<Student>> GetStudents_API()
         {
             return await _httpClient.GetFromJsonAsync<List<Student>>("api/Student/");
         }
        
    }
}