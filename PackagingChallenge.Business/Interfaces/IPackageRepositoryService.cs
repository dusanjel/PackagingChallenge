using PackagingChallenge.Business.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Business.Interfaces
{
    public interface IPackageRepositoryService
    {
        void SavePackage(PackageServiceModel model);
    }
}
