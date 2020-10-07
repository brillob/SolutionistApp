using Solutionists.Model;
using Solutionists.Data.Abstract;
using System.Collections.Generic;

namespace Solutionists.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        //Can inject DBContext if we are using a database.
        public ProductRepository()
        {
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GenerateProducts();
        }

        private List<Product> GenerateProducts()
        {
            List<Product> _products = new List<Product>();
            _products.Add(new Product { Name = "Orange", Price = 2.57, Stock = 10, ProductId = 11, Image = "https://upload.wikimedia.org/wikipedia/commons/7/7b/Orange-Whole-%26-Split.jpg" });
            _products.Add(new Product { Name = "Apple", Price = 3.49, Stock = 20, ProductId = 15, Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Honeycrisp.jpg/240px-Honeycrisp.jpg" });
             return _products;
        }

    }
}
