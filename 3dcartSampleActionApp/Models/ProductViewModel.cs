using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3dcartSampleActionApp.Models
{
    public class ProductViewModel
    {
        public ProductSkuViewModel SKUInfo { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}
