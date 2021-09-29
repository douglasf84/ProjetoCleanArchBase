using CleanArchBase.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanArchBase.MVC.MappingConfig
{
    public static class AutoMappingConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if(services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}
