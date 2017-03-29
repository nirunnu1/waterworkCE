
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace waterwork.Models
{
    public class bill_Water_usage
    {
        [Key]
        public Guid Uid { get; set; }


        [ForeignKey("Water_usage")]
        public Guid Water_usage_id { get; set; }
        public virtual Water_usage Water_usage { get; set; }


        public int water_usagefirst { get; set; }
        public int water_usageafter { get; set; }
        public int unit { get; set; }
        public int service_charge { get; set; }
        public int Minimum_rate { get; set; }
        public int price { get; set; }
        public Statusbill status { get; set; }
        public enum Statusbill { Wait = 0, ready = 1 }
    }
}