using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int InvoiceId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get { return Quantity * Product.Price; } }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId, Product product, int quantity)
        {
            OrderItemId = orderItemId;
            Product = product;
            Quantity = quantity;
        }
    }
}