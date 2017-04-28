using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace waterwork.Models
{
    public class Water_usage
    {
        [Key]
        public Guid Uid { get; set; }
        [ForeignKey("customer_services")]
        public Guid customer_services_id { get; set; }
        public virtual customer_services customer_services { get; set; }
        [ForeignKey("Createinvoiceperiods")]
        public Guid invoiceperiods_id { get; set; }
        public virtual Createinvoiceperiods Createinvoiceperiods { get; set; }

        [Required]
        [Display(Name = "จำนวนหน่วยที่ใช้")]
        public int water_Unit{ get; set; }

        public ICollection<bill_Water_usage> bill_Water_usage { get; set; }

    }
}