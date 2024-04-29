using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Lab2_School_Linq.Models
{
   
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        [ForeignKey("Student")]
        public int FkStudentId { get; set; }
        public virtual Student? Student { get; set; }
        [ForeignKey("Course")]
        public int FkCourseId { get; set; }
        public virtual Course? Course { get; set; }
        [ForeignKey("Teacher")]
        public int FkTeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
