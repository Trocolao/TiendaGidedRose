using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;

namespace PruebaGlidedRose
{
    [TestClass]
    public class AgedBrieTest
    {
        [TestMethod]
        public void AgedBrieTestMethod1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            Tienda tienda = new Tienda(Items);
            tienda.UpdateQuality();
            var AgedBrieCalidad = Items[0].Quality;
            var AgedBrieSellIn = Items[0].SellIn;
            Assert.AreEqual(1, AgedBrieSellIn);
            Assert.AreEqual(1, AgedBrieCalidad);
        }
        [TestMethod]
        public void AgedBrieTestMethod2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            Tienda tienda = new Tienda(Items);
            for(int i=0;i<2; i++)
            {
                tienda.UpdateQuality();
            }
            var AgedBrieCalidad = Items[0].Quality;
            var AgedBrieSellIn = Items[0].SellIn;
            Assert.AreEqual(0, AgedBrieSellIn);
            Assert.AreEqual(2, AgedBrieCalidad);
        }
        [TestMethod]
        public void AgedBrieTestMethod3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 3; i++)
            {
                tienda.UpdateQuality();
            }
            var AgedBrieCalidad = Items[0].Quality;
            var AgedBrieSellIn = Items[0].SellIn;
            Assert.AreEqual(-1, AgedBrieSellIn);
            Assert.AreEqual(4, AgedBrieCalidad);
        }
        [TestMethod]
        public void AgedBrieTestMethod4()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 26; i++)
            {
                tienda.UpdateQuality();
            }
            var AgedBrieCalidad = Items[0].Quality;
            var AgedBrieSellIn = Items[0].SellIn;
            Assert.AreEqual(-24, AgedBrieSellIn);
            Assert.AreEqual(50, AgedBrieCalidad);
        }
    }
}
