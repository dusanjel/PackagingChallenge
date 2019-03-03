using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static PackagingChallenge.Utils.Support.Enums;

namespace PackagingChallenge.Domain.Models
{
    public class PackageList
    {
        [Key]
        public int Id { get; set; }
        public int IndexNumber { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public int Item { get; set; }
    }
}
