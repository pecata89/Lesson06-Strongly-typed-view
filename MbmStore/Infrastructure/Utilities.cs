using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.DAL;

namespace MbmStore.Infrastructure
{
    public class Utilities
    {
        public static void SortCustomers(List<SelectListItem> customers)
        {
            MbmStoreContext db = new MbmStoreContext();

            foreach (Invoice invoice in db.Invoices.Include(c => c.Customer).ToList())
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, Value = invoice.Customer.CustomerId.ToString() });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers
                .GroupBy(x => x.Value)
                .Select(y => y.First())
                .OrderBy(z => z.Text)
                .ToList<SelectListItem>();
        }
    }
}