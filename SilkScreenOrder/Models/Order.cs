using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilkScreenOrder.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public virtual Customer customer { get; set; }

        public virtual Design design { get; set; }

        public virtual Apparel apparel { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DueDate { get; set; }
    }
}