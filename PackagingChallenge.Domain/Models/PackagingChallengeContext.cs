using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingChallenge.Domain.Models
{
    public class PackagingChallengeContext : DbContext
    {
        public PackagingChallengeContext(DbContextOptions<PackagingChallengeContext> options)
            : base(options)
        { }

        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageList> PackageLists { get; set; }
    }
}
