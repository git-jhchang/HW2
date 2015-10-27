using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        Dictionary<int, List<Book>> _book_set = new Dictionary<int, List<Book>>(); // use to group book set

        public ShoppingCart(List<Book> bought_books)
        {
            bool grouped;
            int total_set = 1;
            _book_set.Add(total_set, new List<Book>());
            foreach (var book in bought_books)
            {
                grouped = false;
                foreach (KeyValuePair<int, List<Book>> bookset in _book_set)
                {
                    if (!bookset.Value.Exists(item => item.volume == book.volume))
                    {
                        // book is not in this set, add to this set
                        bookset.Value.Add(book);
                        grouped = true;
                        break;
                    }
                }
                if (!grouped)
                {
                    total_set += 1;
                    _book_set.Add(total_set, new List<Book> { book });
                }
            }
        }

        private double GetDiscount(int booknum)
        {
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
            return discount;
        }

        internal object CountPrice()
        {
            double total = 0;
            foreach (KeyValuePair<int, List<Book>> bookset in _book_set)
            {
                double set_price = 0;
                foreach (var book in bookset.Value)
                {
                    set_price += book.price;
                }
                total += set_price * GetDiscount(bookset.Value.Count);
            }
            return (int)total;
        }
    }

    public class Book
    {
        public int volume { get; set; }
        public double price { get; set; }
    }
}
