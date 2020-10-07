using AutoMapper;
using Solutionists.Model;
using Solutionists.Manager.ViewModels;

namespace Solutionists.Manager.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
           CreateMap<ProductViewModel, Product>();

        }
    }
}
