﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.DAL
{
    public class MbmStoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MbmStoreContext>
    {
        protected override void Seed(MbmStoreContext context)
        {
            // Products
            var products = new List<Product>
            {
                new Book {
                    ProductId = 1,
                    Title = "A Hard Day's Write: The Stories Behind Every Beatles Song",
                    Author = "Steve Turner",
                    Price = 150.00M,
                    Publisher ="It Books",
                    Published = 2005,
                    ISBN ="978-0060844097",
                    ImageUrl = "hard-days-write-jkt-10cm-300dpi2.jpg",
                    Category = "Book"
                },
                new Book {
                    ProductId = 2,
                    Title = "With a Little Help from My Friends: The Making of Sgt. Pepper",
                    Author = "Georg Martin",
                    Price = 180.00M,
                    Publisher = "Little Brown & Co",
                    Published = 1995,
                    ISBN = "0316547832",
                    ImageUrl = "The Making of Sgt. Pepper.jpg",
                    Category = "Book"
                },

                new MusicCD {
                    ProductId = 3,
                    Title = "Abbey Road (Remastered)",
                    Artist = "Beatles",
                    Price = 128.00M,
                    Released = 2009,
                    Label = "EMI",
                    ImageUrl = "Abbey.jpg",
                    Category = "MusicCD",
                    Tracks = new List<Track>
                    {
                        new Track { Title = "Come Together", Length = new TimeSpan(0, 4, 20), Composer = "Lennon, McCartney" },
                        new Track { Title = "Something", Length = new TimeSpan(0, 3, 03), Composer = "Harrison" },
                        new Track { Title = "Maxwell's Silver Hammer", Length = new TimeSpan(0, 3, 29), Composer = "Lennon, McCartney" },
                        new Track { Title = "Oh! Darling", Length = new TimeSpan(0, 3, 26), Composer = "Lennon, McCartney" },
                        new Track { Title = "Octopus's Garden", Length = new TimeSpan(0, 2, 51), Composer = "Starkey" },
                        new Track { Title = "I Want You (She's So Heavy)", Length = new TimeSpan(0, 7, 47), Composer = "Lennon, McCartney" },
                        new Track { Title = "Here Comes The Sun", Length = new TimeSpan(0, 3, 05), Composer = "Harrison" },
                        new Track { Title = "Because", Length = new TimeSpan(0, 2, 45), Composer = "Lennon, McCartney" },
                        new Track { Title = "You Never Give Me Your Money", Length = new TimeSpan(0, 4, 02), Composer = "Lennon, McCartney" },
                        new Track { Title = "Sun King", Length = new TimeSpan(0, 2, 26), Composer = "Lennon, McCartney" },
                        new Track { Title = "Mean Mr. Mustard", Length = new TimeSpan(0, 1, 6), Composer = "Lennon, McCartney" },
                        new Track { Title = "Polythene Pam", Length = new TimeSpan(0, 1, 12), Composer = "Lennon, McCartney" },
                        new Track { Title = "She Came In Through The Bathroom Window", Length = new TimeSpan(0, 1, 57), Composer = "Lennon, McCartney" },
                        new Track { Title = "Golden Slumbers", Length = new TimeSpan(0, 1, 31), Composer = "Lennon, McCartney" },
                        new Track { Title = "Carry That Weight", Length = new TimeSpan(0, 1, 36), Composer = "Lennon, McCartney" },
                        new Track { Title = "The End", Length = new TimeSpan(0, 2, 19), Composer = "Lennon, McCartney" },
                        new Track { Title = "Her Majesty", Length = new TimeSpan(0, 0, 23), Composer = "Lennon, McCartney" }
                    }
                },
                new MusicCD
                {
                    ProductId = 4,
                    Title = "Revolver (Remastered)",
                    Artist = "The Beatles",
                    Price = 128.00M,
                    Released = 2009,
                    Label = "EMI",
                    ImageUrl = "revolver.jpg",
                    Category = "MusicCD",
                    Tracks = new List<Track>
                    {
                        new Track { Title="Taxman", Length=new TimeSpan(0, 2, 28), Composer="Harrison" },
                        new Track { Title="Eleanor Rigby", Length=new TimeSpan(0, 2, 6), Composer="Lennon, McCartney" },
                        new Track { Title="I'm Only Sleeping", Length=new TimeSpan(0, 3, 0), Composer="Lennon, McCartney" },
                        new Track { Title="Love You To", Length=new TimeSpan(0, 2, 59), Composer="Harrison" },
                        new Track { Title="Here, There And Everywhere", Length=new TimeSpan(0, 2, 23), Composer="Harrison" },
                        new Track { Title="Yellow Submarine", Length=new TimeSpan(0, 2, 38), Composer="Lennon, McCartney" },
                        new Track { Title="She Said She Said", Length=new TimeSpan(0, 2, 36), Composer="Lennon, McCartney" },
                        new Track { Title="Good Day Sunshine", Length=new TimeSpan(0, 2, 9), Composer="Lennon, McCartney" },
                        new Track { Title="And Your Bird Can Sing", Length=new TimeSpan(0, 2, 0), Composer="Lennon, McCartney" },
                        new Track { Title="For No One", Length=new TimeSpan(0, 1, 59), Composer="Lennon, McCartney" },
                        new Track { Title="Doctor Robert", Length=new TimeSpan(0, 1, 14), Composer="Lennon, McCartney" },
                        new Track { Title="I Want To Tell You", Length=new TimeSpan(0, 2, 27), Composer="Harrison" },
                        new Track { Title="Got To Get You Into My Life", Length=new TimeSpan(0, 2, 29), Composer="Lennon, McCartney" },
                        new Track { Title="Tomorrow Newer Knows", Length=new TimeSpan(0, 3, 01), Composer="Lennon, McCartney" }
                    }
                },
                // create a new Movie object with instance name jungleBook
                //new Movie(3001, "Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreau"),
                // Create two new instances of Movie object
                // Calling the constructor with an extra argument
                //new Movie(3002, "Midnight in Paris", 150.75m, "midnight.jpg", "Woody Allen"),
                //new Movie(3003, "The Hangover", 180.99m, "hangover.jpg", "Todd Phillips")

                new Movie
                {
                    ProductId = 5,
                    Title = "Jungle Book",
                    Price = 160.50M,
                    ImageUrl = "junglebook.jpg",
                    Director = "Jon Favreau",
                    Category = "Movie"
                },
                new Movie
                {
                    ProductId = 6,
                    Title = "Midnight in Paris",
                    Price = 160.50M,
                    ImageUrl = "midnight.jpg",
                    Director = "Woody Allen",
                    Category = "Movie"
                },
                new Movie
                {
                    ProductId = 7,
                    Title = "The Hangover",
                    Price = 160.50M,
                    ImageUrl = "hangover.jpg",
                    Director = "Todd Phillips",
                    Category = "Movie"
                }
            };

            // populate the database
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();


            // Customers
            var customers = new List<Customer>
            {
                 new Customer {
                     CustomerId = 1,
                     FirstName = "Petko",
                     LastName = "Petkov",
                     Address = "Silkeborgvej 500",
                     Zip= "8220",
                     City = "Aarhus",
                     Birthdate = new DateTime(1989, 2, 25)
                 },
                 new Customer
                 {
                     CustomerId = 2,
                     FirstName = "Minko",
                     LastName = "Todorov",
                     Address = "Silkeborgvej 500",
                     Zip = "8220",
                     City = "Aarhus",
                     Birthdate = new DateTime(1990, 6, 18)
                 }
            };

            // populate the database 
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();


            var invoices = new List<Invoice>
            {
                new Invoice
                {
                    InvoiceId = 1,
                    OrderDate = new DateTime(2016, 09, 12),
                    CustomerId = 1,
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 1, ProductId = 1, Quantity = 77 },
                        new OrderItem { OrderItemId = 2, ProductId = 2, Quantity = 34 },
                        new OrderItem { OrderItemId = 3, ProductId = 5, Quantity = 123 },
                        new OrderItem { OrderItemId = 4, ProductId = 6, Quantity = 94 }
                    }
                },
                new Invoice
                {
                    InvoiceId = 2,
                    OrderDate = new DateTime(2016, 09, 18),
                    CustomerId = 2,
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 5, ProductId = 3, Quantity = 56 },
                        new OrderItem { OrderItemId = 6, ProductId = 4, Quantity = 91 },
                        new OrderItem { OrderItemId = 7, ProductId = 7, Quantity = 56 }
                    }
                }
            };
            // populate the database

            invoices.ForEach(i => context.Invoices.Add(i));
            context.SaveChanges();
        }
    }   
}