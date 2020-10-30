using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3dcartSampleActionApp.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public int OrderStatusID { get; set; }
        public int? BillingPaymentMethodID { get; set; }
        public string InvoiceNumberPrefix { get; set; }
        public int InvoiceNumber { get; set; }
        public int CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string UserID { get; set; }
        public string SalesPerson { get; set; }
        public string AlternateOrderID { get; set; }
        public string OrderType { get; set; }
        public string PaymentTokenID { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingCompany { get; set; }
        public string BillingAddress { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipCode { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingEmail { get; set; }
    }
}
