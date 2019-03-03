using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPackageListRepository PackageLists { get; }
        IPackageRepository Packages { get; }
        int SaveChanges();
    }
}
