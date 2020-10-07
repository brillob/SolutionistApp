using Microsoft.AspNetCore.Mvc;
using Solutionists.Data.Abstract;
using System.Threading.Tasks;
using Solutionists.Manager;
using Solutionists.Manager.ViewModels;

namespace Solutionists.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productManager.GetAllProducts();
            return new OkObjectResult(products);
        }
   
      
    }

}
