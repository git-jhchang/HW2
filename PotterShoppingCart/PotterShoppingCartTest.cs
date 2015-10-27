using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Test1_第一集買一本_其他都沒買_價格應為100乘以1等於100元()
        {
            // arrange
            var bought_books = new List<Book>
            {
                new Book { name = "vol 1", price = 100 }
            };
            var target = new ShoppingCart(bought_books);
            var expected = 100;

            // act
            var actual = target.CountPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2_第一集買一本_第二集也買一本_價格應為100乘以2乘以0dot95等於190元()
        {
            // arrange
            var bought_books = new List<Book>
            {
                new Book { name = "vol 1", price = 100 },
                new Book { name = "vol 2", price = 100 }
            };
            var target = new ShoppingCart(bought_books);
            var expected = 190;

            // act
            var actual = target.CountPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
