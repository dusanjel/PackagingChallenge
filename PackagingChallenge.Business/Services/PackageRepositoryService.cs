using PackagingChallenge.Business.Interfaces;
using PackagingChallenge.Business.ServiceModels;
using PackagingChallenge.Domain.Interfaces;
using PackagingChallenge.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PackagingChallenge.Business.Services
{
    public class PackageRepositoryService : IPackageRepositoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public PackageRepositoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void SavePackage(PackageServiceModel model)
        {
            var Package = new Package()
            {
                MaxWeight = model.MaxWeight,
                PackageList = new List<PackageList>()
            };

            foreach (var pack in model.PackageList)
            {
                var PackageList = new PackageList()
                {
                    Cost = pack.Cost,
                    IndexNumber = pack.IndexNumber,
                    Item = (int)pack.Item,
                    Weight = pack.Weight
                };

                Package.PackageList.Add(PackageList);
            }          

            unitOfWork.Packages.Add(Package);
            unitOfWork.SaveChanges();
        }     
    }
}
