using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAppication_pr1.Models;
using MvcAppication_pr1.Models.Product;
using System.Diagnostics;

namespace MvcAppication_pr1.Controllers
{
    public class PersonController : Controller
    {

        private readonly ApplicationDbContext contextDb;

        public PersonController(ApplicationDbContext contextDb)
        {
            this.contextDb = contextDb;
        }

        public async Task<IActionResult> Index()
        {
            var PersonsList = await contextDb.Persons.ToListAsync();
            return View(PersonsList);

            //return View(ProductRepo.ProductsList);
        }


        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
    
        public async Task<IActionResult> SavePerson([FromForm] Person data)
        {
            bool isDuplicate = await contextDb.Persons.AnyAsync(p => p.FirstName == data.FirstName);

            if (isDuplicate)
            {
                ModelState.AddModelError("FirstName", "Name is already taken.");
            }

            if (ModelState.IsValid)
            {
                await contextDb.Persons.AddAsync(data);
                await contextDb.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View("AddPerson", data);
        }



        [HttpPost]
        public async Task<IActionResult> DelPerson(int id)
        {
            Debug.WriteLine(id);

            var product = await contextDb.Persons.FindAsync(id);
            if (product != null)
            {
                contextDb.Persons.Remove(product);
                await contextDb.SaveChangesAsync();
            }
            return RedirectToAction("Index");

        }



        public async Task<IActionResult> Update(int id)
        {
            Debug.WriteLine(id);
            var person = await contextDb.Persons.FindAsync(id);
            if (person != null)
            {
                return View(person);
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> UpdatePerson([FromForm] Person data)
        {
            if (ModelState.IsValid)
            {
                contextDb.Persons.Update(data);
                await contextDb.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("Update", data);
        }



        public IActionResult Mem()
        {
            ViewBag.Greetings = "Hello World";
            return View();
        }

        [HttpGet]
        public IActionResult Ind()
        {
            return Content("Hi Ramesh Vanaparthi");
        }

       
    }
}
