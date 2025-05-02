using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAppication_pr1.Models;

namespace MvcAppication_pr1.Controllers
{
    public class PersonController1 : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PersonController1(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var Persons = await dbContext.Persons.ToListAsync();
            return View(Persons);
        }
    }
}
