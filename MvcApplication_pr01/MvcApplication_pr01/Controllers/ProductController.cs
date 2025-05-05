using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcApplication_pr01.Data;
using MvcApplication_pr01.Models.Entitys;
using System.Diagnostics;

namespace MvcApplication_pr01.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await dbContext.products.ToListAsync();
            return View(products);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct([FromForm] Product data)
        {
            if (ModelState.IsValid)
            {
                dbContext.products.AddAsync(data);

                await dbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> DeltProduct(int id)
        {
            Debug.WriteLine(id);
            var product = await dbContext.products.FindAsync(id);

            if (product != null)
            {
                dbContext.products.Remove(product);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id)
        {
            Debug.WriteLine(id);
            var product = await dbContext.products.FindAsync(id);
            if(product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateProduct([FromForm] Product data)
        {
            if (ModelState.IsValid)
            {
                dbContext.products.Update(data);

                await dbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View("Update",data);
        }
    }
}
