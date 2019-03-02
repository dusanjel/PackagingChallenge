using PackagingChallenge.Utils.Support;
using System;
using System.Collections.Generic;
using System.Text;
using static PackagingChallenge.Utils.Support.Enums;

namespace PackagingChallenge.Business.ServiceModels
{
    public class PackageListServiceModel
    {
        //TODO describe and document fields for swagger
        // Use http://localhost:port/swagger/ to access swagger test page.
        public int IndexNumber { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public Items Item { get; set; }
    }
}
