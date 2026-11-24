using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Data;
using StudentManagementAPI.Models.DTO;
using StudentManagementAPI.Models.Entity;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDbContext _dbContext;

        public StudentsController(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /api/students
        // Operation: Get All Students
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Student>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _dbContext.Students.ToListAsync();
            return Ok(students);
        }

        // GET: /api/students/{id}
        // Operation: Get Student by ID
        [HttpGet("{id:guid}")]
        [ProducesResponseType(typeof(Student), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentById([FromRoute] Guid id)
        {
            var student = await _dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound(new { message = $"Student with ID '{id}' was not found." });
            }

            return Ok(student);
        }

        // POST: /api/students
        // Operation: Add Student
        [HttpPost]
        [ProducesResponseType(typeof(Student), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddStudent([FromBody] AddStudentDto addStudentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = new Student
            {
                StudentId = Guid.NewGuid(),
                Name = addStudentDto.Name,
                Email = addStudentDto.Email,
                Phone = addStudentDto.Phone,
                Age = addStudentDto.Age,
                Course = addStudentDto.Course,
                Address = addStudentDto.Address
            };

            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudentById), new { id = student.StudentId }, student);
        }

        // PUT: /api/students/{id}
        // Operation: Update Student
        [HttpPut("{id:guid}")]
        [ProducesResponseType(typeof(Student), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateStudent([FromRoute] Guid id, [FromBody] UpdateStudentDto updateStudentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = await _dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound(new { message = $"Student with ID '{id}' was not found." });
            }

            student.Name = updateStudentDto.Name;
            student.Email = updateStudentDto.Email;
            student.Phone = updateStudentDto.Phone;
            student.Age = updateStudentDto.Age;
            student.Course = updateStudentDto.Course;
            student.Address = updateStudentDto.Address;

            await _dbContext.SaveChangesAsync();

            return Ok(student);
        }

        // DELETE: /api/students/{id}
        // Operation: Delete Student
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteStudent([FromRoute] Guid id)
        {
            var student = await _dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound(new { message = $"Student with ID '{id}' was not found." });
            }

            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();

            return Ok(new { message = "Student deleted successfully.", deletedStudent = student });
        }
    }
}
