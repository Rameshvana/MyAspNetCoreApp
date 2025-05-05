using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcApplication_pr01.Data;
using MvcApplication_pr01.Models.Entitys;
using System.Diagnostics;

namespace MvcApplication_pr01.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


       
        public async Task<IActionResult> Students()
        {
            //var studunts = await dbContext.Students.ToListAsync();

            var students1 = await dbContext.Students
                                .FromSqlRaw("EXEC GetAllStudents")
                                .ToListAsync();

            Debug.WriteLine(students1);
           

            return View(students1);
        }


        public IActionResult Add()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> SaveStudent([FromForm] Student data)
        {
            if (!ModelState.IsValid)
            {
                return View("Add", data);
            }

            await dbContext.Database.ExecuteSqlRawAsync(
                "EXEC InsertStudent @FirstName, @LastName, @Email, @Age, @Course, @Address",
                new SqlParameter("@FirstName", data.FirstName ?? ""),
                new SqlParameter("@LastName", data.LastName ?? ""),
                new SqlParameter("@Email", data.Email ?? ""),
                new SqlParameter("@Age", data.Age),
                new SqlParameter("@Course", data.Course ?? ""),
                new SqlParameter("@Address", data.Address ?? "")
            );

            return RedirectToAction("Students");
        }


        [HttpPost]
        public async Task<IActionResult> Update(int id)
        {
            
            Debug.WriteLine(id);

            var student = await dbContext.Students.FindAsync(id);

            if (student != null)
            {
                return View(student);
            }
            return RedirectToAction("Students");
        }

        public async Task<IActionResult> UpdateStudent([FromForm] Student data)
        {
            if (ModelState.IsValid)
            {
                await dbContext.Database.ExecuteSqlRawAsync(
                    "EXEC UpdateStudent @Id, @FirstName, @LastName, @Email, @Age, @Course, @Address",
                    new SqlParameter("@Id",data.Id),
                    new SqlParameter("@FirstName", data.FirstName ?? ""),
                    new SqlParameter("@FirstName", data.FirstName ?? ""),
                    new SqlParameter("@LastName", data.LastName ?? ""),
                    new SqlParameter("@Email", data.Email ?? ""),
                    new SqlParameter("@Age", data.Age),
                    new SqlParameter("@Course", data.Course ?? ""),
                    new SqlParameter("@Address", data.Address ?? "")
);
                TempData["SuccessMessage"] = "Student Adedd successfully.";
                return RedirectToAction("Students");
            }

            return View("Update", data);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            Debug.WriteLine(id); 

            await dbContext.Database.ExecuteSqlRawAsync(
                "EXEC DeleteStudent @Id",
                new SqlParameter("@Id", id)
            );

            TempData["SuccessMessage"] = "Student deleted successfully.";
            return RedirectToAction("Students");
        }
    }
}
