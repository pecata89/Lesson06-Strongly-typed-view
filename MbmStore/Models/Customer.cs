using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Birthdate { get; set; }



        // read only property
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - Birthdate.Year;
                if (now.Month < Birthdate.Month ||
                    (now.Month == Birthdate.Month && now.Day < Birthdate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Phone> PhoneNumbers { get; set; }
        

        // cunstructors
        public Customer() { }

        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
        }

        // method
        public void AddPhone(Phone phone)
        {
            PhoneNumbers.Add(phone);
        }

    }
}