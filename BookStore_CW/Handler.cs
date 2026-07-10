using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_CW
{
    internal class Handler
    {
        public BookContext context {  get; set; }
        public Handler()
        {
            context = new BookContext();
        }
        public void Load()
        {
            Migrate();
            context.Books.Load();
            context.SoldBooks.Load();
            context.DefferedBooks.Load();
            context.BooksOnSale.Load();
            context.Costumers.Load();
            Dummy();
        }

        private void Migrate()
        {
            context.Database.Migrate();
        }

        private void Dummy()
        {
            if (!context.Books.Any()) {
                Book book = new Book() {Name = "The Kite Runner", Author= "Khaled Hosseini", 
                    Cost = 120, Genre = "Drama", Pages = 352, Price = 250, 
                    PublishName= "Riverhead Books", Type = Type.None, YearofPublish = 2003,
                    PictureURL= "https://m.media-amazon.com/images/I/81CA-WqU+lL._SY466_.jpg"
                };
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        
    }
}
