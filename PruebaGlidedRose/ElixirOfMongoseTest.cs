using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;


namespace PruebaGlidedRose
{
    [TestClass]
    public class ElixirOfMongoseTest
    {
        [TestMethod]
        public void ElixirOfMongoseTestMethod1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 1; i++)
            {
                tienda.UpdateQuality();
            }
            var ElixirOfMongoseCalidad = Items[0].Quality;
            var ElixirOfMongoseSellIn = Items[0].SellIn;
            Assert.AreEqual(4, ElixirOfMongoseSellIn);
            Assert.AreEqual(6, ElixirOfMongoseCalidad);
        }
        [TestMethod]
        public void ElixirOfMongoseTestMethod2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 2; i++)
            {
                tienda.UpdateQuality();
            }
            var ElixirOfMongoseCalidad = Items[0].Quality;
            var ElixirOfMongoseSellIn = Items[0].SellIn;
            Assert.AreEqual(3, ElixirOfMongoseSellIn);
            Assert.AreEqual(5, ElixirOfMongoseCalidad);
        }
        [TestMethod]
        public void ElixirOfMongoseTestMethod3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 3; i++)
            {
                tienda.UpdateQuality();
            }
            var ElixirOfMongoseCalidad = Items[0].Quality;
            var ElixirOfMongoseSellIn = Items[0].SellIn;
            Assert.AreEqual(2, ElixirOfMongoseSellIn);
            Assert.AreEqual(4, ElixirOfMongoseCalidad);
        }
        [TestMethod]
        public void ElixirOfMongoseTestMethod4()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 4; i++)
            {
                tienda.UpdateQuality();
            }
            var ElixirOfMongoseCalidad = Items[0].Quality;
            var ElixirOfMongoseSellIn = Items[0].SellIn;
            Assert.AreEqual(1, ElixirOfMongoseSellIn);
            Assert.AreEqual(3, ElixirOfMongoseCalidad);
        }
        [TestMethod]
        public void ElixirOfMongoseTestMethod5()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 5; i++)
            {
                tienda.UpdateQuality();
            }
            var ElixirOfMongoseCalidad = Items[0].Quality;
            var ElixirOfMongoseSellIn = Items[0].SellIn;
            Assert.AreEqual(0, ElixirOfMongoseSellIn);
            Assert.AreEqual(2, ElixirOfMongoseCalidad);
        }
        [TestMethod]
        public void ElixirOfMongoseTestMethod6()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 6; i++)
            {
                tienda.UpdateQuality();
            }
            var ElixirOfMongoseCalidad = Items[0].Quality;
            var ElixirOfMongoseSellIn = Items[0].SellIn;
            Assert.AreEqual(-1, ElixirOfMongoseSellIn);
            Assert.AreEqual(0, ElixirOfMongoseCalidad);
        }
    }
}
