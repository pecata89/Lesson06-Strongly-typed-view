using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        // auto-implemented properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public int CustomerId { get; set; }


        // List collection of type string
        private List<string> phoneNumbers { get; set; } = new List<string>();
        private DateTime birthDate;

        private DateTime now = DateTime.Now;
        private int age;

        public DateTime BirthDate
        {
            get
            {
                if (Age < 0 || Age > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    return birthDate;
                }
            }
            set { birthDate = value; }
        }

        public int Age
        {
            get
            {
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }

        // Property
        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
        }

        // Method that takes no parameters and returns no value - void
        public void AddPhone(string phone)
        {
            phoneNumbers.Add(phone);    
        }

        // Constructors
        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city, DateTime birthDate)
        {
            CustomerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.birthDate = birthDate;
        }
    }
}