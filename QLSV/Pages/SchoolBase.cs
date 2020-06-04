using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using QLSV.Models;
using QLSV.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Pages
{
    public class SchoolBase : ComponentBase
    {
        [Inject]
        public ISchoolService SchoolService { get; set; }
        [Inject]
        public  IJSRuntime JsRuntime { get; set; }
        public List<School> _Schools { get; set; }
        //cont
        public School Model = new School();

        protected string ButtonText { get; set; } = "Thêm mới";
        protected string CssClass { get; set; } = "Hide_FormAdd";
        public string _TenTruong { get; set; }

        protected override void OnInitialized()
        {
            _Schools = (List<School>)SchoolService.GetShools();
        }

        public void AddSchool()
        {
            if (!string.IsNullOrWhiteSpace(Model.ShoolName))
            {
                var Data = new School();
                Data.ShoolName = Model.ShoolName;
                SchoolService.AddSchool(Data);
                _Schools = SchoolService.GetShools().ToList();
                Model.ShoolName = "";
            }
        }

        public async Task DeleteSchool(int ID)
        {
           bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure ?");
            if (confirmed)
            {
                if (ID > 0)
                {
                    SchoolService.DeleteSchool(ID);
                    _Schools = SchoolService.GetShools().ToList();
                }
            }
             
           
        }

        public void DoTheThing(KeyboardEventArgs eventArgs)
        {
            if (eventArgs.Key == "Enter")
            {
                AddSchool();
            }
        }

        protected void Button_Click()
        {
            if (ButtonText == "Thêm mới")
            {
                ButtonText = "Ẩn thêm";
                CssClass = null;
            }
            else
            {
                ButtonText = "Thêm mới";
                CssClass = "Hide_FormAdd";
            }
        }
    
    }
}