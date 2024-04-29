using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2_School_Linq.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        [ForeignKey("CourseClass")]
        public int FkCourseClassId { get; set; }
        public CourseClass? CourseClass { get; set; }
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
