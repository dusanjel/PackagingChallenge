using PackagingChallenge.Domain.Interfaces;
using PackagingChallenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Domain.Repositories
{
    public class PackageListRepository : GenericRepository<PackageList>, IPackageListRepository
    {
        public PackageListRepository(PackagingChallengeContext context) : base(context)
        {
        }

        public PackagingChallengeContext PackagingChallengeContext
        {
            get { return Context as PackagingChallengeContext; }
        }
    }
}
