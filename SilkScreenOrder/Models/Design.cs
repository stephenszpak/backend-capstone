using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilkScreenOrder.Models
{
    public class Design
    {
        [Key]
        public int DesignId { get; set; }

        public string NumberOfColors { get; set; }

        public decimal DesignFee { get; set; }

        public bool CustomerProvidedDesign { get; set; }
    }
}