using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MbmStore.Models
{
    [Table("Movie")]
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
        public Movie()
        {

        }

        public Movie(string title, decimal price, string director) : base(title, price)
        {
            Director = director;
        }
    }
}