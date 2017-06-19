using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilkScreenOrder.Models
{
    public class OrderForm
    {
        [Key]
        public int OrderFormId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime OrderDueDate { get; set; }

        public int OrderNumber { get; set; }

        public string SalesPerson { get; set; }

        public string AdditionalNotes { get; set; }

        public decimal PrintingFee { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual Apparel Apparel { get; set; }
        public virtual Design Design { get; set; }
        public virtual Customer Customer { get; set; }

    }
}