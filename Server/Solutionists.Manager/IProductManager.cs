using System;
using System.Collections.Generic;
using System.Text;
using Solutionists.Manager.ViewModels;

namespace Solutionists.Manager
{
   public interface IProductManager
    {
        IEnumerable<ProductViewModel> GetAllProducts();
     }
}
