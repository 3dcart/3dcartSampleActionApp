using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3dcartSampleActionApp.Models
{    
    public class ProductSkuViewModel
    {
        public int CatalogID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public double RetailPrice { get; set; }
        public double SalePrice { get; set; }
        public bool OnSale { get; set; }
        public double Stock { get; set; }
    }
}
