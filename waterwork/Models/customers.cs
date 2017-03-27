using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace waterwork.Models
{
    public class customers
    {
        [Key]
        public Guid Uid { get; set; }
        [Display(Name = "ชื่อ")]
        [Required]
        public string firstname { get; set; }
        [Display(Name = "นามสกุล")]
        [Required]
        public string lastname { get; set; }
        [Display(Name = "วันเดือนปีเกิด")]
        [Required]
        public DateTime birthdate { get; set; }
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
        [Display(Name = "อาชีพ")]
        public string occupation { get; set; }
        [Display(Name = "Email address")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }
        public ICollection<customer_services> customer_services { get; set; }

        public static IEnumerable GetSearchUserProfile()
        {
            AssetDbContext Context = new AssetDbContext();
           return Context.customers.ToList();
        }
        public static IEnumerable GetUserProfile(string id)
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.customers.Where(x=>x.Uid.ToString() == id).ToList();
        }


        public static void Insertcustomers(customers item)
        {
            AssetDbContext Context = new AssetDbContext();
            if (item != null)
            {
                item.Uid = Guid.NewGuid();
                Context.customers.Add(item);
                Context.SaveChanges();
            }
        }
    }
    
}