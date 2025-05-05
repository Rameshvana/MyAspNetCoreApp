using Microsoft.AspNetCore.Mvc;
using MvcAdo.Net_Projct1.Models.Product;

using System;
using System.Diagnostics;

namespace MvcAdo.Net_Projct1.Controllers
{
    public class ProductController : Controller
    {
        public readonly ProductRepo _repo;

        public ProductController(IConfiguration config)
        {
            _repo = new ProductRepo(config);
        }
        public IActionResult Index()
        {
            var products = _repo.GetProducts();

            Debug.WriteLine(products);

            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SaveProduct([FromForm] Product data)
        {
            Debug.WriteLine(data);

            if (ModelState.IsValid)
            {
                string resultMessage = _repo.InsertProduct(data); // This returns a success or error message
                return RedirectToAction("Index", new { message = resultMessage });
            }

            return View("Add",data);
        }

        public IActionResult DeltProduct(int id)
        {
            Debug.WriteLine(id);

            string resultMessage = _repo.DeleteProduct(id);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(int id)
        {
            var products = _repo.GetProducts();

            var product = products.FirstOrDefault(p => p.Id == id);

            return View(product);
        }

        public IActionResult UpdateProduct([FromForm] Product data)
        {
            Debug.WriteLine(data);
            string message = _repo.UpdateProduct(data);

            if(message != null)
            {
                return RedirectToAction("Index");
            }

            return View("Update", data);
        }




    }
}
