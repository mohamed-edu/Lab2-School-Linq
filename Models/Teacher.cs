namespace Lab2_School_Linq.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
