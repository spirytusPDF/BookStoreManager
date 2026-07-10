using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_CW
{
    public enum Type
    {
        Sequel,
        Prequel,
        None
    }

    public enum ViewType
    {
        All,
        Sold_out,
        Sales,
        Deffered,
        News,
    }

    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookOnSale> BooksOnSale { get; set; }
        public DbSet<SoldBook> SoldBooks { get; set; }
        public DbSet<DefferedBooks> DefferedBooks { get; set; }
        public DbSet<User> Costumers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging()
              .UseSqlite("Data Source=BookStore.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<SoldBook>().ToTable("SoldBooks");
            modelBuilder.Entity<BookOnSale>().ToTable("BooksOnSale");
            modelBuilder.Entity<DefferedBooks>().ToTable("DefferedBooks");

           
        }
    }

   
    [Table(nameof(BookContext.Books))]
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string PublishName { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;

        public Type Type { get; set; }

        public int Pages { get; set; }
        public int YearofPublish { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }

        public string? PictureURL { get; set; } = string.Empty;
    }

    [Table(nameof(BookContext.BooksOnSale))]
    public class BookOnSale : Book
    {
        
        public int SalePercent { get; set; }
        public decimal NewPrice { get; set; }
    }

    [Table(nameof(BookContext.SoldBooks))]
    public class SoldBook : Book
    {
        
        public string Sold { get; } = "Sold";
    }
    [Table(nameof(BookContext.DefferedBooks))]
    public class DefferedBooks : Book
    {
        public int UserId { get; set; }
        public User User { get; set; } = new();
        [NotMapped]
        public string UserName => User?.Name;
    }
    [Table(nameof(BookContext.Costumers))]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<DefferedBooks> DefferedBooks { get; set; } = new List<DefferedBooks>();
    }
}
