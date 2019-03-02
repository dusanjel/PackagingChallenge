using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using PackagingChallenge.Domain.IoC;


namespace PackagingChallenge.Business.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPackagingChallengeBusiness(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();            

            services.AddPackagingChallengeDomain();            
            return services;
        }
    }
}
