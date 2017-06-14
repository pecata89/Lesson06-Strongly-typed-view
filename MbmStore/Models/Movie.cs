using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }  
        

        //public decimal Price 
        //{
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            throw new Exception("Price is not accepted");
        //        }
        //        else {
        //            price = value;
        //        }
        //    }
        //    get { return price; }
        //}


        // constructors
        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Movie(int productId, string title, decimal price, string imageUrl, string director) : base (productId, title, price, imageUrl)
        {
            this.director = director;
        }
    }
}