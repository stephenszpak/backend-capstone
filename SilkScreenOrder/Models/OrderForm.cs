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
    
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public int CustomerPhone { get; set; }

        public string CustomerEmail { get; set; }

        public string ApparelType { get; set; }

        public string ApparelBrand { get; set; }

        public int ApparelQuantity { get; set; }

        public decimal ApparelPricePerPiece { get; set; }

        public string ApparelColor { get; set; }

        public string AmountOfColorsOfDesign { get; set; }

        public decimal DesignHeight { get; set; }

        public decimal DesignWidth { get; set; }

        public decimal DesignFee { get; set; }

        public string LogoLocations { get; set; }

        public string InkColorsToBeUsed { get; set; }

        public string AdditionalNotes { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual Apparel Apparel { get; set; }
        public virtual Design Design { get; set; }
        public virtual Customer Customer { get; set; }

    }
}