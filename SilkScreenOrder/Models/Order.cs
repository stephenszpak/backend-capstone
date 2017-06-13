﻿using System;
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

        public IEnumerable<OrderForm> OrderForm { get; set; }
        
    }
}