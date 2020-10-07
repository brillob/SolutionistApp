using Solutionists.Model;
using System.Collections.Generic;

namespace Solutionists.Data.Abstract
{
   
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }

}
