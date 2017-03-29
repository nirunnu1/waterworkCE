using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace waterwork.Models
{
    public class Createinvoiceperiods
    {
        [Key]
        public Guid Uid { get; set; }
        public DateTime date { get; set; }

        public ICollection<Water_usage> Water_usage { get; set; }

    }
}