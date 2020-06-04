using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QLSV.Models;
using QLSV.Service;
using QLSV.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Pages
{
    public class ClassBase : ComponentBase
    {
        [Inject]
        public IClassService ClassService { get; set; }
        [Inject]
        public ISchoolService SchoolService { get; set; }
        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        //Cont
        public Class Model = new Class();
        public List<School> Schools { get; set; } = new List<School>();
        public List<Class> _Classes { get; set; }
        public List<ClassViewModel> _ClassViewModel { get; set; }

        public string ClassName = "";
        protected string ButtonText = "Thêm mới";
        protected string CssClass = "Hide_FormAdd";

        protected override void OnInitialized()
        {
            _Classes = ClassService.GetClasses().ToList();
            _ClassViewModel = ClassService.GetClassViewModels().ToList();
            Schools = SchoolService.GetShools().ToList();       
        }
        //service
        public void AddClass()
        {
            if (!string.IsNullOrWhiteSpace(Model.ClassName))
            {
                var Data = new Class();
                Data.ClassName = Model.ClassName;
                Data.School_ID = Model.School_ID;
                ClassService.AddClass(Data);
                Model.ClassName = "";            
                _ClassViewModel = ClassService.GetClassViewModels().ToList();
            }
        }
        public async Task DeleteClassByID(int ID)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure ?");
            if (confirmed)
            {
                if (ID > 0)
                {
                    ClassService.DeleteClass(ID);
                    _ClassViewModel = (List<ClassViewModel>)ClassService.GetClassViewModels();
                }
            }

        }

        public void Button_Click()
        {
            if (ButtonText == "Thêm mới")
            {
                ButtonText = "Ẩn thêm mới";
                CssClass = null;
            }
            else
            {
                ButtonText = "Thêm mới";
                CssClass = "Hide_FormAdd";
            }
        }

        /*public void Select_Change(ChangeEventArgs e)
        {
            School_ID = int.Parse(e.Value.ToString());
        }*/
    }
}