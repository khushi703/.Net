using lab11_3.DAO;
using lab11_3.Models.StudentApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace lab11_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly StudentDAO _studentDAO;
        private readonly IMemoryCache _cache;

        public StudentsController(StudentDAO studentDAO, IMemoryCache cache)
        {
            _studentDAO = studentDAO;
            _cache = cache;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            if (!_cache.TryGetValue("students", out IEnumerable<Student> students))
            {
                students = await _studentDAO.GetAllStudentsAsync();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60));

                _cache.Set("students", students, cacheOptions);
            }

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _studentDAO.GetStudentByIdAsync(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newStudent = await _studentDAO.AddStudentAsync(student);
            _cache.Remove("students"); // clear cache
            return CreatedAtAction(nameof(GetStudentById), new { id = newStudent.StudentId }, newStudent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student student)
        {
            if (id != student.StudentId) return BadRequest();

            var updatedStudent = await _studentDAO.UpdateStudentAsync(student);
            if (updatedStudent == null) return NotFound();

            _cache.Remove("students");
            return Ok(updatedStudent);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var deleted = await _studentDAO.DeleteStudentAsync(id);
            if (!deleted) return NotFound();

            _cache.Remove("students");
            return NoContent();
        }
    }
}
