using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2_School_Linq.Models
{
    public class CourseClass
    {

        [Key]
        public int CourseClassId { get; set; }
        public string? CourseClassName { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
