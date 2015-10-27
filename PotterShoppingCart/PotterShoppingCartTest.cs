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
        public void Test2_第一集買一本_第二集也買一本_價格應為100乘以2乘以95percent等於190元()
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

        [TestMethod]
        public void Test3_一二三集各買了一本_價格應為100乘以3乘以90percent等於270元()
        {
            // arrange
            var bought_books = new List<Book>
            {
                new Book { name = "vol 1", price = 100 },
                new Book { name = "vol 2", price = 100 },
                new Book { name = "vol 3", price = 100 }
            };
            var target = new ShoppingCart(bought_books);
            var expected = 270;

            // act
            var actual = target.CountPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4_一二三四集各買了一本_價格應為100乘以4乘以80percent等於320元()
        {
            // arrange
            var bought_books = new List<Book>
            {
                new Book { name = "vol 1", price = 100 },
                new Book { name = "vol 2", price = 100 },
                new Book { name = "vol 3", price = 100 },
                new Book { name = "vol 4", price = 100 }
            };
            var target = new ShoppingCart(bought_books);
            var expected = 320;

            // act
            var actual = target.CountPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5_一二三四五集各買了一本_價格應為100乘以5乘以75percent等於375元()
        {
            // arrange
            var bought_books = new List<Book>
            {
                new Book { name = "vol 1", price = 100 },
                new Book { name = "vol 2", price = 100 },
                new Book { name = "vol 3", price = 100 },
                new Book { name = "vol 4", price = 100 },
                new Book { name = "vol 5", price = 100 }
            };
            var target = new ShoppingCart(bought_books);
            var expected = 375;

            // act
            var actual = target.CountPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6_一二集各買了一本_第三集買了兩本_價格應為100乘以3乘以90percent加100等於370元()
        {
            // arrange
            var bought_books = new List<Book>
            {
                new Book { name = "vol 1", price = 100 },
                new Book { name = "vol 2", price = 100 },
                new Book { name = "vol 3", price = 100 },
                new Book { name = "vol 3", price = 100 },
            };
            var target = new ShoppingCart(bought_books);
            var expected = 370;

            // act
            var actual = target.CountPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
