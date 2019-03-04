using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PackagingChallenge.Domain.Models;
using PackagingChallenge.Domain.Repositories;
using PackagingChallenge.Domain.Interfaces;

namespace PackagingChallenge.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPackagingChallengeDomain(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTransient<IUnitOfWork, UnitOfWork>();            
            services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddSingleton(typeof(IPackageListRepository), typeof(PackageListRepository));
            services.AddSingleton(typeof(IPackageRepository), typeof(PackageRepository));


            // Change in accordance to your db directory
            var connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dusan\PackagingChallenge\PackagingChallenge.Domain\Database\PackagingChallenge.mdf;Integrated Security=True";
            services.AddDbContext<PackagingChallengeContext>
                (options => options.UseSqlServer(connection));
            return services;
        }
    }
}
