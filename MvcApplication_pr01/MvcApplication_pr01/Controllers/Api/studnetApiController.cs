using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcApplication_pr01.Data;
using MvcApplication_pr01.Models.Entitys;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApplication_pr01.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class studnetApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public studnetApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/studnet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: api/studnet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return NotFound();

            return student;
        }


        // POST: api/studnet
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok($"Successfully Adedd student from the table {student.Id}");

            //return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        // PUT: api/studnet/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
                return BadRequest();

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Students.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return Ok($"Successfully Updated student from the table {student.Id}");
        }

        // DELETE: api/studnet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return Ok($"Successfully deleted student from the table {student.Id}");
        }
    }
}
