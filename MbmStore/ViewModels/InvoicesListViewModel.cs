using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.ViewModels
{
    public class InvoicesListViewModel
    {
        public IEnumerable<Invoice> Invoices { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}