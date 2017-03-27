using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace waterwork.Models
{
    public class customer_services
    {
        [Key]
        public Guid Uid { get; set; }
        [Display(Name = "รหัสผู้ใช้งาน")]
        [Required]
        [ForeignKey("customer")]
        public Guid customer_id { get; set; }
        [Display(Name = "เลขมิสเตอ")]
        public int meter_id { get; set; }
        [Display(Name = "วันที่ขอใช้งาน")]
        public DateTime service_date { get; set; }
        [Display(Name = "บ้านเลขที่")]
        [Required]
        public string house_id { get; set; }
        [Display(Name = "หมู่ที่่")]
        [Required]
        public string village_id { get; set; }
        [Display(Name = "ตำบล")]
        [Required]
        public string place { get; set; }
        [Display(Name = "อำเภอ")]
        [Required]
        public string amphur { get; set; }
        [Display(Name = "จังหวัด")]
        [Required]
        public string province { get; set; }
        public Status status { get; set; }
        public virtual customers customer { get; set; }
        public enum Status { Wait = 0, ready = 1 }
        public static IEnumerable Getcustomer_services()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.customer_services.ToList();
        }
        public static void Insertcustomer_services(customer_services item)
        {
            AssetDbContext Context = new AssetDbContext();
            if (item != null)
            {
                item.Uid = Guid.NewGuid();
                Context.customer_services.Add(item);
                Context.SaveChanges();
            }
        }
    }
}