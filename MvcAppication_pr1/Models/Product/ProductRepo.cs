using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MvcAppication_pr1.Models.Product
{
    public class ProductRepo
    {
        // Corrected type to List<Product>
        public static List<Product> ProductsList { get; set; }

        // Static constructor initializes the product list
        static ProductRepo()
        {
            ProductsList = new List<Product>
            {
                new Product(1, "Laptop", "A high-performance laptop.", 999.99m, 50, "Electronics"),
                new Product(2, "Smartphone", "Latest model smartphone.", 699.99m, 100, "Electronics"),
                new Product(3, "Headphones", "Noise-cancelling headphones.", 199.99m, 75, "Accessories")
            };
        }

        public static void AddProduct(Product newProduct)
        {
            Debug.WriteLine(newProduct);

            if (newProduct != null)
            {
                newProduct.Id = (ProductsList.LastOrDefault()?.Id ?? 0) + 1;
                ProductsList.Add(newProduct);
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = ProductsList.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                ProductsList.Remove(product);
            }
        }

        public static void UpdateProduct(Product updateProduct)
        {
            var existingProduct = ProductsList.FirstOrDefault(p => p.Id == updateProduct.Id);

            if (existingProduct != null)
            {
                existingProduct.Name = updateProduct.Name;
                existingProduct.Description = updateProduct.Description;
                existingProduct.Price = updateProduct.Price;
                existingProduct.StockQuantity = updateProduct.StockQuantity;
                existingProduct.Category = updateProduct.Category;
            }
        }
    }
}
