using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public class Utilities
    {
        public static void SortCustomers(List<SelectListItem> customers)
        {
            Repository repository = new Repository();

            foreach (Invoice invoice in repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.firstName + " " + invoice.Customer.lastName, Value = invoice.Customer.CustomerId.ToString() });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();
        }
    }
}