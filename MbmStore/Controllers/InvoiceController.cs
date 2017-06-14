using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        // instantiating repository class
        // don't forget to declare the object private 
        private Repository repository = new Repository();

        private List<SelectListItem> customers = new List<SelectListItem>();

        // GET: Invoice
        public ActionResult Index()
        {
            Utilities.SortCustomers(customers);

            ViewBag.CustomerId = customers;

            ViewBag.Invoices = repository.Invoices;

            return View();
        }

        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {
            if (CustomerId != null)
            {
                // select invoices for a customer with linq
                ViewBag.Invoices = repository.Invoices.Where(r => r.Customer.CustomerId == CustomerId);
            }
            else
            {
                ViewBag.Invoices = repository.Invoices;
            }

            Utilities.SortCustomers(customers);
            ViewBag.CustomerId = customers;

            return View();
        }
    }
}