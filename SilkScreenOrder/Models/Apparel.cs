using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilkScreenOrder.Models
{
    public class Apparel
    {
        [Key]
        public int ApparelId { get; set; }

        public string ApparelType { get; set; }

        public string ApparelBrand { get; set; }

        public int ApparelQuantity { get; set; }

        public decimal ApparelPricePerPiece { get; set; }

        public string ApparelColor { get; set; }

    }
}