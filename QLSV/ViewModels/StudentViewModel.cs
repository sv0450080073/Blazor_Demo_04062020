using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.ViewModels
{
    public class StudentViewModel
    {
        public int Class_ID { get; set; }
        public List<Student> students { get; } = new List<Student>();
    }
}
