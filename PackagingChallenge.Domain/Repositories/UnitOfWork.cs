using PackagingChallenge.Domain.Interfaces;
using PackagingChallenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PackagingChallengeContext _context;
        
        public UnitOfWork(PackagingChallengeContext context)
        {
            _context = context;
            PackageLists = new PackageListRepository(_context);
            Packages = new PackageRepository(_context);            
        }

        public IPackageListRepository PackageLists { get; private set; }
        public IPackageRepository Packages { get; private set; }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
