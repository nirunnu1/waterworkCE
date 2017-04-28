using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace waterwork.Models
{
    public class Createinvoiceperiods
    {
        [Key]
        public Guid Uid { get; set; }
        public DateTime date { get; set; }
        /// <summary>
        /// จำนวนผู้ใช้งาน
        /// </summary>
        public int num { get; set; }
        public Statusinvoiceperiods status { get; set; }
        public ICollection<Water_usage> Water_usage { get; set; }
        public enum Statusinvoiceperiods { Wait = 0, ready = 1 }

    }
}