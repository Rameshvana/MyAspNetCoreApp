using Microsoft.AspNetCore.Mvc;
using MvcAppication_pr1.Models.Product;
using System.Diagnostics;

namespace MvcAppication_pr1.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult Index()
        {
            var productsList = ProductRepo.ProductsList;


            return View();
        }

        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveProduct([FromForm] Product data)
        {
            Debug.WriteLine($"Saving: {data.Name}");

            if (!ModelState.IsValid)
            {
                return View("AddProduct", data);
            }

            ProductRepo.AddProduct(data);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            ProductRepo.DeleteProduct(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = ProductRepo.ProductsList.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct([FromForm] Product data)
        {
            Debug.WriteLine($"Updating: {data.Name}");

            if (!ModelState.IsValid)
            {
                return View("Update", data);
            }

            ProductRepo.UpdateProduct(data);

            return RedirectToAction("Index");
        }
    }
}
