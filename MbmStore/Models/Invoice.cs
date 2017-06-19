using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;
        public ICollection<OrderItem> OrderItems { get; set; }

        public int InvoiceId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Customer> Customers { get; set; }

        public decimal TotalPrice
        {
            get
            {
                totalPrice = 0;

                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.TotalPrice;
                }

                return totalPrice;
            }
        }


        //public void AddOrderItem(int orderItemId, Product product, int quantity)
        //{
        //    OrderItem item = orderItems.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();

        //    if (item == null)
        //    {
        //        orderItems.Add(new OrderItem(orderItemId, product, quantity));
        //    }
        //    else
        //    {
        //        item.Quantity += quantity;
        //    }
        //}

        public Invoice()
        {

        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }
    }
}