using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV.Data;
using QLSV.Models;

namespace QLSV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly QLSVDbContext _qLSVDbContext;
        public StudentController(QLSVDbContext qLSVDbContext)
        {
            _qLSVDbContext = qLSVDbContext;
        }



        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            try
            {
                return Ok(await _qLSVDbContext.Students.ToListAsync());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Lổi get list data");

            }
        }


        [HttpPost]
         public  async Task<ActionResult> AddStudent(Student student)
         {
            try
            {
                if (student == null)
                {
                    return BadRequest();

                }              
                var createStudent = _qLSVDbContext.Students.AddAsync(student);
                await _qLSVDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetStudents),new {student.ID },createStudent);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Lổi lưu  data");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Student>> DeleteStudentById(int id)
        {
            try
            {
                var StudentToDelete = await _qLSVDbContext.Students.FindAsync(id);
                if(StudentToDelete ==null)
                {
                    return NotFound($"Student with ID ={id} not found ");

                }
                 _qLSVDbContext.Students.Remove(StudentToDelete);
                await _qLSVDbContext.SaveChangesAsync();
                return StudentToDelete;
            }
            catch(Exception )
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Lổi xóa  data");
            }
        }




    }
}
