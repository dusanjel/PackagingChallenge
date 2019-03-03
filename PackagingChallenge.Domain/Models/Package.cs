using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PackagingChallenge.Domain.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }
        public int MaxWeight { get; set; }       
        public List<PackageList> PackageList { get; set; }
    }
}
