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
            double total = 0;
            foreach (var book in _bought_books)
            {
                total += book.price;
            }
            int booknum = this._bought_books.Count;
            double discount = 1;
            switch (booknum)
            {
                case 5:
                    discount -= 0.25;
                    break;
                case 4:
                    discount -= 0.2;
                    break;
                case 3:
                    discount -= 0.1;
                    break;
                case 2:
                    discount -= 0.05;
                    break;
            }
            return (int)(total * discount);
        }
    }

    public class Book
    {
        public string name { get; set; }
        public double price { get; set; }
    }
}
