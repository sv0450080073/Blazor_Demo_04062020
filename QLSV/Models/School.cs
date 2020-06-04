using System.ComponentModel.DataAnnotations;

namespace QLSV.Models
{
    public class School
    {
        [Key]
        public int ID { get; set; }    
        [Required]
        public string ShoolName { get; set; }
    }
}