using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using _3dcartSampleActionApp.Interfaces;
using _3dcartSampleActionApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3dcartSampleActionApp.Controllers
{
    public class CheckStatusController : Controller
    {
        private readonly I3dcartRestApiService __3dcartRestApiService;
        public CheckStatusController(I3dcartRestApiService _3dcartRestApiService)
        {
            __3dcartRestApiService = _3dcartRestApiService;
        }

        // GET: CheckStatusController?id=5&token=5555
        public async Task<ActionResult> Index(string page, int id, string token)
        {
            if (!(await ProcessRequestAsync(page, id, token)))
                return BadRequest("Something went wrong, check for missing parameters.");

            ViewBag.Layout = "_Layout";

            return View();
        }

        // GET: CheckStatusController/Embedded?id=5&token=5555
        public async Task<ActionResult> Embedded(string page, int id, string token)
        {

            if (!(await ProcessRequestAsync(page, id, token)))
                return BadRequest("Something went wrong, check for missing parameters.");
            
            ViewBag.Layout = "_LayoutEmbedded";

            return View("Index");
        }

        private async Task<bool> ProcessRequestAsync(string page, int id, string token)
        {
            if (id == 0 || string.IsNullOrEmpty(token))
            {
                return false;
            }
            else
            {
                string storeSecureUrl = string.Empty;

                switch (token)
                {                    
                    case "fake_sample_token":                        
                        break;
                    case "PUT_STORE_TOKEN_HERE_FOR_TESTING":
                        storeSecureUrl = "PUT_STORE_SECURE_URL_HERE_FOR_TESTING";
                        break;
                    default:
                        return false;
                }                

                ViewBag.Id = id;
                ViewBag.Token = token;
                ViewBag.Page = page;

                switch (page)
                {
                    case "customer":
                        var customerModel = (await __3dcartRestApiService.MakeRequestAsync<List<CustomerViewModel>>("customers", token, id, storeSecureUrl)).FirstOrDefault();
                        ViewBag.ItemInfo = $"Customer name: {customerModel.BillingFirstName}, Billing Address: {customerModel.BillingAddress1}";
                        break;
                    case "order":
                        var orderModel = (await __3dcartRestApiService.MakeRequestAsync<List<OrderViewModel>>("orders", token, id, storeSecureUrl)).FirstOrDefault();
                        ViewBag.ItemInfo = $"Invoice number: {orderModel.InvoiceNumber}, Order Date: {orderModel.OrderDate}";
                        break;
                    case "product":
                        var productModel = (await __3dcartRestApiService.MakeRequestAsync<List<ProductViewModel>>("products", token, id, storeSecureUrl)).FirstOrDefault();
                        ViewBag.ItemInfo = $"Product SKU: {productModel.SKUInfo.SKU}, Stock: {productModel.SKUInfo.Stock}, Description: {productModel.ShortDescription}";
                        break;
                    case "sample":
                        ViewBag.ItemInfo = "This is the sample request";
                        break;
                    default:
                        break;
                }

                return true;
            }
        }
    }
}
