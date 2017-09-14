using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TShirtStore.WebUI.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageFile { get; set; }
    }
}