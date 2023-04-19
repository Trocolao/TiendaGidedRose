using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;

namespace PruebaGlidedRose
{
    [TestClass]
    public class ConcertBackStageTest
    {
        [TestMethod]
        public void ConcertBackStageTest1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 1; i++)
            {
                tienda.UpdateQuality();
            }
            var ConcertCalidad = Items[0].Quality;
            var ConcertSellIn = Items[0].SellIn;
            Assert.AreEqual(14, ConcertSellIn);
            Assert.AreEqual(21, ConcertCalidad);
        }

        [TestMethod]
        public void ConcertBackStageTest2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 2; i++)
            {
                tienda.UpdateQuality();
            }
            var ConcertCalidad = Items[0].Quality;
            var ConcertSellIn = Items[0].SellIn;
            Assert.AreEqual(13, ConcertSellIn);
            Assert.AreEqual(22, ConcertCalidad);
        }
        [TestMethod]
        public void ConcertBackStageTest3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 6; i++)
            {
                tienda.UpdateQuality();
            }
            var ConcertCalidad = Items[0].Quality;
            var ConcertSellIn = Items[0].SellIn;
            Assert.AreEqual(9, ConcertSellIn);
            Assert.AreEqual(27, ConcertCalidad);
        }
        [TestMethod]
        public void ConcertBackStageTest4()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 11; i++)
            {
                tienda.UpdateQuality();
            }
            var ConcertCalidad = Items[0].Quality;
            var ConcertSellIn = Items[0].SellIn;
            Assert.AreEqual(4, ConcertSellIn);
            Assert.AreEqual(38, ConcertCalidad);
        }
        [TestMethod]
        public void ConcertBackStageTest5()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 15; i++)
            {
                tienda.UpdateQuality();
            }
            var ConcertCalidad = Items[0].Quality;
            var ConcertSellIn = Items[0].SellIn;
            Assert.AreEqual(0, ConcertSellIn);
            Assert.AreEqual(50, ConcertCalidad);
        }
        [TestMethod]
        public void ConcertBackStageTest6()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 16; i++)
            {
                tienda.UpdateQuality();
            }
            var ConcertCalidad = Items[0].Quality;
            var ConcertSellIn = Items[0].SellIn;
            Assert.AreEqual(-1, ConcertSellIn);
            Assert.AreEqual(0, ConcertCalidad);
        }
    }
}
