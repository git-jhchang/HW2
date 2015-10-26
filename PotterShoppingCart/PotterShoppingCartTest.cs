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

            // asert
            Assert.AreEqual(expected, actual);
        }
    }
}
