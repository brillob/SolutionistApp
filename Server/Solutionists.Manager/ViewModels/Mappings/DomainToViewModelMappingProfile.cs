using AutoMapper;
using Solutionists.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Solutionists.Manager.ViewModels;

namespace Solutionists.Manager.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();


        }
    }
}
