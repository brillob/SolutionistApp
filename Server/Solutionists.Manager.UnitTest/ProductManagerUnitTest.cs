using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Solutionists.Data;
using Solutionists.Data.Abstract;
using Solutionists.Data.Repositories;
using Solutionists.Manager.Validations;
using Solutionists.Manager.ViewModels;
using System.Linq;
using Solutionists.Manager.Mappings;

namespace Solutionists.Manager.UnitTest
{
    [TestClass]
    public class ProductManagerUnitTest
    {
        private IProductManager _productManager { set; get; }
        public ProductManagerUnitTest()
        {
            _productManager = InitializeProductManager();

        }
        private IProductManager InitializeProductManager()
        {
            IProductRepository iProductRepository = InitializeProductRespository();
            AutoMapperConfiguration.Configure();
            IProductManager iProductManager = new ProductManager(iProductRepository);
            return iProductManager;
        }
       

        private static IProductRepository InitializeProductRespository()
        {

            IProductRepository iProductRepository = new ProductRepository();
            return iProductRepository;
        }

        [TestMethod]
        public void GetProducts()
        {
              var result = _productManager.GetAllProducts();
              Assert.IsTrue(result.ToList().Count > 0);
        }

      }
}
