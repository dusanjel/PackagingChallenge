using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using PackagingChallenge.Domain.IoC;
using PackagingChallenge.Domain.Interfaces;
using PackagingChallenge.Domain.Repositories;
using PackagingChallenge.Domain.Models;

namespace PackagingChallenge.Business.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPackagingChallengeBusiness(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<PackagingChallengeContext, PackagingChallengeContext>();         

            services.AddPackagingChallengeDomain();            
            return services;
        }
    }
}
