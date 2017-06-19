using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
using MbmStore.DAL;
using MbmStore.ViewModels;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private MbmStoreContext db;

        private List<SelectListItem> customers = new List<SelectListItem>();

        public InvoiceController()
        {
            db = new MbmStoreContext();
        }

        // GET: Invoice
        public ActionResult Index()
        {
            InvoicesListViewModel model = new InvoicesListViewModel()
            {
                Invoices = db.Invoices.Include(i => i.Customer).ToList(),
                OrderItems = db.OrderItems.Include(i => i.Product).ToList()
            };

            Utilities.SortCustomers(customers);
            ViewBag.CustomerId = customers;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {
            InvoicesListViewModel model;

            if (CustomerId != null)
            {
                model = new InvoicesListViewModel()
                {
                    Invoices = db.Invoices
                        .Include(i => i.Customer)
                        .Where(c => c.Customer.CustomerId == CustomerId)
                        .ToList(),
                    OrderItems = db.OrderItems.Include(i => i.Product).ToList()
                };
            }
            else
            {
                model = new InvoicesListViewModel()
                {
                    Invoices = db.Invoices
                        .Include(i => i.Customer)
                        .ToList(),
                    OrderItems = db.OrderItems.Include(i => i.Product).ToList()
                };
            }

            Utilities.SortCustomers(customers);
            ViewBag.CustomerId = customers;

            return View(model);
        }
    }
}