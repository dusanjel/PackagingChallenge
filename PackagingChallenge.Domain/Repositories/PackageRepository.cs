using PackagingChallenge.Domain.Interfaces;
using PackagingChallenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Domain.Repositories
{
    public class PackageRepository : GenericRepository<Package>, IPackageRepository
    {
        public PackageRepository(PackagingChallengeContext context) : base(context)
        {
        }

        public PackagingChallengeContext PackagingChallengeContext
        {
            get { return Context as PackagingChallengeContext; }
        }
    }
}
