
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
        [Display(Name = "หน่วยของน้ำเดือนก่อน")]

        public int water_usagefirst { get; set; }
        [Display(Name = "เลขอ่าน")]
        public int water_usageafter { get; set; }
        [Display(Name = "จำนวนหน่วยที่ใช้")]
        public int unit { get; set; }
        [Display(Name = "ค่าบริการ")]
        public int service_charge { get; set; }
        [Display(Name = "ขั้นต่ำ")]
        public int Minimum_rate { get; set; }
         [Display(Name = "จำนวนเงิน")]
        public int price { get; set; }
        public Statusbill status { get; set; }
        public enum Statusbill { Wait = 0, ready = 1 }
    }
}