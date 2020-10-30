using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3dcartSampleActionApp.Models
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public string Email { get; set; }        
        public string BillingCompany { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
    }
}
