using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Business.ServiceModels
{
    public class PackageServiceModel
    {
        //TODO describe and document fields for swagger
        /// Use http://localhost:port/swagger/ to access swagger test page.
        public int MaxWeight { get; set; }
        public List<PackageListServiceModel> PackageList { get; set; }
    }
}
