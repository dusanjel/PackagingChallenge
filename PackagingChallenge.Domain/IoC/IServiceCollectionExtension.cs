using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPackagingChallengeDomain(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();           
            return services;
        }
    }
}
