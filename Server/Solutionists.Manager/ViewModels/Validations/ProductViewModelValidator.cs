using FluentValidation;
using System;
using Solutionists.Manager.ViewModels;

namespace Solutionists.Manager.Validations
{
    public class ProductViewModelValidator : AbstractValidator<ProductViewModel>
    {
        public ProductViewModelValidator()
        {

            //Rules for Price
            RuleFor(x => x.Price).GreaterThanOrEqualTo(0);

            //Rules for Product Name
            RuleFor(x => x.Name).NotEmpty();

            //Rule for Stock
            RuleFor(x => x.Stock).GreaterThanOrEqualTo(0);

         
        }

    }
}
