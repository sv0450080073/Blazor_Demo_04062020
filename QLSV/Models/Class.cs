using System.ComponentModel.DataAnnotations;

namespace QLSV.Models
{
    public class Class
    {
        [Key]
        public int ID { get; set; }

        public string ClassName { get; set; }
        public int School_ID { get; set; }
    }
}