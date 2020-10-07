using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using Solutionists.Data.Abstract;
using Solutionists.Manager.ViewModels;
using Solutionists.Model;

namespace Solutionists.Manager
{
    public class ProductManager : IProductManager
    {
        private IProductRepository _productRepository;
     
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
           
        }
     
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            IEnumerable<Product> _products = _productRepository.GetAllProducts();
                
            IEnumerable<ProductViewModel> _productVM = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_products);
            return _productVM;
        }
      
    }
}
