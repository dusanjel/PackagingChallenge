using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Business.ServiceModels
{
    public class PackageServiceModel
    {
        public int MaxWeight { get; set; }
        public List<PackageListServiceModel> PackageList { get; set; }
    }
}
