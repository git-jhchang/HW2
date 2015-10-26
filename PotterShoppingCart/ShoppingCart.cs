using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<Book> _bought_books;

        public ShoppingCart(List<Book> bought_books)
        {
            // TODO: Complete member initialization
            this._bought_books = bought_books;
        }


        internal object CountPrice()
        {
            throw new NotImplementedException();
        }
    }

    public class Book
    {
        public string name { get; set; }
        public double price { get; set; }
    }
}
