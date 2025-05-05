using Microsoft.AspNetCore.Mvc;
using MvcAdo.Net_Projct1.Models.Student;
using System;
using System.Diagnostics;

namespace MvcAdo.Net_Projct1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepo _repo;

        public StudentController(IConfiguration config)
        {
            _repo = new StudentRepo(config);
        }

        public IActionResult Index()
        {
            var students = _repo.GetStudents();
            Debug.WriteLine(students);

            return View(students);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateStudent([FromForm] Student data)
        {
            Debug.WriteLine(data);

            if (data != null)
            {
                string message = _repo.UpdateStudent(data);
                TempData["SuccessMessage"] = message;

                return RedirectToAction("Index");

            }
            
            return View("Update",data);
        }

        [HttpPost]
        public IActionResult Update(int id)
        {
            var student_list = _repo.GetStudents();

            var student = student_list.FirstOrDefault(p => p.Id == id);

            if(student != null)
            {
                return View(student);

               // TempData["SuccessMessage"] = message;

            }

            return View();

        }
        [HttpPost]
        public IActionResult SaveStudent([FromForm] Student data)

        {
            Debug.WriteLine(data);

            if (ModelState.IsValid)
            {
                string message = _repo.AddStudent(data);

                if (message != null)
                {
                    TempData["SucessMEssage"] = message;

                    return RedirectToAction("Index");
                }

                return View("Add");
            }
            return View("Add");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Debug.WriteLine(id);

            var message = _repo.DeleteStudent(id);
            if (message!= null)
            {
                TempData["SuccessMessage"] = message;

                return RedirectToAction("Index");
            }
            return View("Index");

        }
    }
}
