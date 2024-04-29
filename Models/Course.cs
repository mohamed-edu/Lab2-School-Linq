using System.ComponentModel.DataAnnotations;

namespace Lab2_School_Linq.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
