using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Business.ServiceModels
{
    public class PackageServiceModel
    {
        //TODO describe and document fields for swagger
        public int MaxWeight { get; set; }
        public List<PackageListServiceModel> PackageList { get; set; }
    }
}
