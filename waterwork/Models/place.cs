using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace waterwork.Models
{
    public class place
    {
        [System.ComponentModel.DataAnnotations.KeyAttribute()]

        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("amphur")]
        public int amphur_id { get; set; }
        public virtual amphur amphur { get; set; }

        public ICollection<customer_services> customer_services { get; set; }
        public ICollection<customers> customer_scustomerservices { get; set; }
    }
    public class amphur
    {
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("province")]
        public int province_id { get; set; }
        public virtual province province { get; set; }

        public ICollection<place> place { get; set; }
        public ICollection<customer_services> customer_services { get; set; }
        public ICollection<customers> customers { get; set; }
    }
    public class province
    {
        [System.ComponentModel.DataAnnotations.KeyAttribute()]

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<amphur> amphur { get; set; }
        public ICollection<customer_services> customer_services { get; set; }
        public ICollection<customers> customers { get; set; }
    }
}