using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.JSInterop;
using QLSV.Models;
using QLSV.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Pages
{
    public class StudentBase : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }
        [Inject]
        public IClassService ClassService { get; set; }
        [Inject]
        public IJSRuntime JsRuntime { get; set; }
       
        public List<Student> _Student { get; set; }
        public List<Class> _Class { get; set; }

        public Student Model = new Student();

        protected override async Task OnInitializedAsync()
        {
            _Student = (List<Student>)await StudentService.GetStudents_API();
            _Class = (List<Class>)ClassService.GetClasses();
        }
        protected async Task AddStudent()
        {
            if (Model.StudentName!="" && Model.Class_ID>0)
            {
                await StudentService.AddStudent(Model);

            }
            _Student = await StudentService.GetStudents_API();
        }

        protected async Task DeleteStudent(int ID)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure ?");
            if (confirmed)
            {
                if (ID > 0)
                {
                    await StudentService.DeleteStudent(ID);
                }
                _Student = await StudentService.GetStudents_API();
            }
        }
    }
}