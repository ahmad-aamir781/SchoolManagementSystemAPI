using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;
using SchoolManagementSystemAPI.Data;
using System.Threading.Tasks;

namespace School_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // Teacher CRUD

        [HttpGet("Teachers")]
        public async Task<IActionResult> GetTeachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return Ok(teachers);
        }

        [HttpPost("Teacher")]
        public async Task<IActionResult> CreateTeacher([FromBody] Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.T_id }, teacher);
        }

        [HttpGet("Teacher/{id}")]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }

        [HttpPut("Teacher/{id}")]
        public async Task<IActionResult> UpdateTeacher(int id, [FromBody] Teacher teacher)
        {
            if (id != teacher.T_id)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("Teacher/{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Student CRUD

        [HttpGet("GetStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            if(student.Std_Name == null)
            {
                return BadRequest();
            }
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Student/{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPut("Student/{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student student)
        {
            if (id != student.Std_id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("Student/{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Subject CRUD

        [HttpGet("Subjects")]
        public async Task<IActionResult> GetSubjects()
        {
            var subjects = await _context.Subjects.ToListAsync();
            return Ok(subjects);
        }

        [HttpPost("Subject")]
        public async Task<IActionResult> CreateSubject([FromBody] Subject subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSubjectById), new { id = subject.Sbj_id }, subject);
        }

        [HttpGet("Subject/{id}")]
        public async Task<IActionResult> GetSubjectById(int id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            return Ok(subject);
        }

        [HttpPut("Subject/{id}")]
        public async Task<IActionResult> UpdateSubject(int id, [FromBody] Subject subject)
        {
            if (id != subject.Sbj_id)
            {
                return BadRequest();
            }

            _context.Entry(subject).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("Subject/{id}")]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }

            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        // Grade CRUD

        [HttpGet("Grades")]
        public async Task<IActionResult> GetGrades()
        {
            var grades = await _context.Grades.ToListAsync();
            return Ok(grades);
        }

        [HttpPost("Grade")]
        public async Task<IActionResult> CreateGrade([FromBody] Grade grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGradeById), new { id = grade.Grd_id }, grade);
        }

        [HttpGet("Grade/{id}")]
        public async Task<IActionResult> GetGradeById(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
            {
                return NotFound();
            }
            return Ok(grade);
        }

        [HttpPut("Grade/{id}")]
        public async Task<IActionResult> UpdateGrade(int id, [FromBody] Grade grade)
        {
            if (id != grade.Grd_id)
            {
                return BadRequest();
            }

            _context.Entry(grade).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("Grade/{id}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
            {
                return NotFound();
            }

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Term CRUD

        [HttpGet("Terms")]
        public async Task<IActionResult> GetTerms()
        {
            var terms = await _context.Terms.ToListAsync();
            return Ok(terms);
        }

        [HttpPost("Term")]
        public async Task<IActionResult> CreateTerm([FromBody] Term term)
        {
            _context.Terms.Add(term);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTermById), new { id = term.Trm_id }, term);
        }

        [HttpGet("Term/{id}")]
        public async Task<IActionResult> GetTermById(int id)
        {
            var term = await _context.Terms.FindAsync(id);
            if (term == null)
            {
                return NotFound();
            }
            return Ok(term);
        }

        [HttpPut("Term/{id}")]
        public async Task<IActionResult> UpdateTerm(int id, [FromBody] Term term)
        {
            if (id != term.Trm_id)
            {
                return BadRequest();
            }

            _context.Entry(term).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("Term/{id}")]
        public async Task<IActionResult> DeleteTerm(int id)
        {
            var term = await _context.Terms.FindAsync(id);
            if (term == null)
            {
                return NotFound();
            }

            _context.Terms.Remove(term);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Class CRUD

        [HttpGet("Classes")]
        public async Task<IActionResult> GetClasses()
        {
            var classes = await _context.Classs.ToListAsync();
            return Ok(classes);
        }

        [HttpPost("Class")]
        public async Task<IActionResult> CreateClass([FromBody] Class cls)
        {
            _context.Classs.Add(cls);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetClassById), new { id = cls.Class_id }, cls);
        }

        [HttpGet("Class/{id}")]
        public async Task<IActionResult> GetClassById(int id)
        {
            var cls = await _context.Classs.FindAsync(id);
            if (cls == null)
            {
                return NotFound();
            }
            return Ok(cls);
        }

        [HttpPut("Class/{id}")]
        public async Task<IActionResult> UpdateClass(int id, [FromBody] Class cls)
        {
            if (id != cls.Class_id)
            {
                return BadRequest();
            }

            _context.Entry(cls).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("Class/{id}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            var cls = await _context.Classs.FindAsync(id);
            if (cls == null)
            {
                return NotFound();
            }

            _context.Classs.Remove(cls);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
