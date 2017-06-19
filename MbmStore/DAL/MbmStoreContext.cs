using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MbmStore.Models;

// Data Access Layer
namespace MbmStore.DAL
{
    public class MbmStoreContext : DbContext
    {
        // constructor
        public MbmStoreContext() : base("MbmStoreContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<MusicCD> MusicCDs { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);
            modelBuilder.Entity<OrderItem>()
                .HasKey(k => k.OrderItemId);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}