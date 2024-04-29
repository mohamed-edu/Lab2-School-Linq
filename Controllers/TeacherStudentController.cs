using Lab2_School_Linq.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2_School_Linq.Controllers
{
    public class TeacherStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> TheStudents()
        {
            var students = _context.Students.Include(s => s.CourseClass);
            return View(await students.ToListAsync());
        }

        public async Task<IActionResult> TeacherAndCourses()
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Teacher)
                .Include(e => e.Course);
            return View(await enrollment.ToListAsync());

            

        }
       

    }
}
