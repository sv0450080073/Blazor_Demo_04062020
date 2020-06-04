using System.ComponentModel.DataAnnotations;

namespace QLSV.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string StudentName { get; set; }
        public int Class_ID { get; set; }
    }
}