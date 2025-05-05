using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blazor_StudentApp.Connection;
using Blazor_StudentApp.Models;

namespace Blazor_StudentApp.Controllers.Api
{
    [Route("api/student")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            return student;
        }

        [HttpPost]
        public async Task<IActionResult> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok($"Successfully added student with ID: {student.Id}");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
                return BadRequest();
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok($"Successfully updated student with ID: {student.Id}");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Ok($"Successfully deleted student with ID: {student.Id}");
        }
    }
}
