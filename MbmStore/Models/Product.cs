using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace MbmStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        //public int OrderItemId { get; set; }
        //[ForeignKey("OrderItemId")]
        //public OrderItem OrderItem { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
    }
}