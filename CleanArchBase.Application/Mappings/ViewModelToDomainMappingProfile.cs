using AutoMapper;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;

namespace CleanArchBase.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}
