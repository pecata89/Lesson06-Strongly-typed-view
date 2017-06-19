//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using MbmStore.Models;

//namespace MbmStore.Infrastructure
//{
//    public class Repository
//    {
//        public List<Product> Products = new List<Product>();
//        public List<Invoice> Invoices = new List<Invoice>();

//        public Repository()
//        {

//            Book book = new Book();
//            MusicCD musicCD = new MusicCD();

//            // creating an object of each type sub classes
//            Book b1 = new Book(1001, "Emotions Revealed", 10.07m, "emotions.jpg", "Paul Ekman", "Holt Paperbacks", 2007, "978-0805083392");
//            Book b2 = new Book(1002, "Telling Lies", 9.27m, "lies.jpg", "Paul Ekman", "W. W. Norton & Company", 2009, "978-0393337457");
//            b1.Category = "Book";
//            b2.Category = "Book";

//            MusicCD cd1 = new MusicCD(2001, "I Am Not a Human Being", 35.99m, "nhb1.jpg", "Lil Wayne", "Young Money, Cash Money, Universal Motown", 2010);
//            cd1.Category = "MusicCD";

//            cd1.AddTrack(new Track("Gonorrhea", new TimeSpan(0, 4, 22)));
//            cd1.AddTrack(new Track("Hold Up", new TimeSpan(0, 4, 11)));
//            cd1.AddTrack(new Track("With You", new TimeSpan(0, 3, 49)));
//            cd1.AddTrack(new Track("I Am Not a Human Being", new TimeSpan(0, 4, 05)));
//            cd1.AddTrack(new Track("I'm Single", new TimeSpan(0, 5, 33)));
//            cd1.AddTrack(new Track("What's Wrong with Them", new TimeSpan(0, 3, 31)));
//            cd1.AddTrack(new Track("Right Above It", new TimeSpan(0, 4, 32)));
//            cd1.AddTrack(new Track("Popular", new TimeSpan(0, 4, 40)));
//            cd1.AddTrack(new Track("That Ain't Me", new TimeSpan(0, 4, 03)));
//            cd1.AddTrack(new Track("Bill Gates", new TimeSpan(0, 4, 19)));
//            cd1.AddTrack(new Track("YM Banger", new TimeSpan(0, 3, 55)));
//            cd1.AddTrack(new Track("YM Salute", new TimeSpan(0, 5, 14)));
//            cd1.AddTrack(new Track("I Don't Like the Look of It", new TimeSpan(0, 3, 18)));

//            MusicCD cd2 = new MusicCD(2002, "I Am Not a Human Being 2", 11.84m, "nhb2.jpg", "Lil Wayne", "Young Money, Cash Money, Republic", 2013);
//            cd2.Category = "MusicCD";

//            cd2.AddTrack(new Track("IANAHB", new TimeSpan(0, 5, 38)));
//            cd2.AddTrack(new Track("Curtains", new TimeSpan(0, 4, 31)));
//            cd2.AddTrack(new Track("Days and Days", new TimeSpan(0, 3, 13)));
//            cd2.AddTrack(new Track("Gunwalk", new TimeSpan(0, 4, 31)));
//            cd2.AddTrack(new Track("No Worries", new TimeSpan(0, 3, 41)));
//            cd2.AddTrack(new Track("Back to You", new TimeSpan(0, 5, 29)));
//            cd2.AddTrack(new Track("Trigger Finger", new TimeSpan(0, 4, 32)));
//            cd2.AddTrack(new Track("Beat the Shit", new TimeSpan(0, 4, 28)));
//            cd2.AddTrack(new Track("Rich As Fuck", new TimeSpan(0, 3, 43)));
//            cd2.AddTrack(new Track("Trippy", new TimeSpan(0, 4, 23)));
//            cd2.AddTrack(new Track("Love Me", new TimeSpan(0, 4, 13)));
//            cd2.AddTrack(new Track("Romance", new TimeSpan(0, 4, 20)));
//            cd2.AddTrack(new Track("God Bless Amerika", new TimeSpan(0, 5, 03)));
//            cd2.AddTrack(new Track("Wowzerz", new TimeSpan(0, 3, 45)));
//            cd2.AddTrack(new Track("Hello", new TimeSpan(0, 4, 02)));

//            // create a new Movie object with instance name jungleBook
//            Movie m1 = new Movie(3001, "Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreau");
//            m1.Category = "Movie";

//            // Create two new instances of Movie object
//            // Calling the constructor with an extra argument
//            Movie m2 = new Movie(3002, "Midnight in Paris", 150.75m, "midnight.jpg", "Woody Allen");
//            Movie m3 = new Movie(3003, "The Hangover", 180.99m, "hangover.jpg", "Todd Phillips");
//            m2.Category = "Movie";
//            m3.Category = "Movie";

//            Products.Add(b1);
//            Products.Add(b2);
//            Products.Add(cd1);
//            Products.Add(cd2);
//            Products.Add(m1);
//            Products.Add(m2);
//            Products.Add(m3);

//            // Customer objects
//            Customer c1 = new Customer(1, "Petko", "Petkov", "Silkeborgvej 500", "8220", "Aarhus", new DateTime(1989, 2, 25));
//            Customer c2 = new Customer(2, "Minko", "Todorov", "Silkeborgvej 500", "8220", "Aarhus", new DateTime(1990, 6, 18));

//            //c1.AddPhone("+4550327870");
//            //c1.AddPhone("+4566778899");

//            //c2.AddPhone("+4570783258");

//            // ORDER ITEMS
//            OrderItem oi1 = new OrderItem(cd2, 74);
//            OrderItem oi2 = new OrderItem(cd1, 63);
//            OrderItem oi3 = new OrderItem(b1, 52);
//            OrderItem oi4 = new OrderItem(b2, 41);
//            OrderItem io5 = new OrderItem(m1, 299);
//            OrderItem oi6 = new OrderItem(m2, 101);

//            Invoice i1 = new Invoice(488, new DateTime(2017, 6, 7), c1);
//            Invoice i2 = new Invoice(1163, new DateTime(2017, 6, 11), c2);

//            i1.AddOrderItem(cd1, 3);
//            i1.AddOrderItem(b2, 4);
//            i1.AddOrderItem(m3, 7);
//            i2.AddOrderItem(m2, 2);
//            i2.AddOrderItem(b1, 9);

//            Invoices.Add(i1);
//            Invoices.Add(i2);


//        }
//    }
//}