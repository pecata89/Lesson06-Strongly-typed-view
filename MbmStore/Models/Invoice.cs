﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;
        private List<OrderItem> orderItems = new List<OrderItem>();

        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal TotalPrice {
            get
            {
                foreach (OrderItem item in orderItems)
                {
                    totalPrice = totalPrice + item.Product.Price;
                }

                return totalPrice;
            }
        }

        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get { return orderItems; } }

        public void AddOrderItem(Product product, int quantity)
        {
            orderItems.Add(new OrderItem(product, quantity));
        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }
    }
}