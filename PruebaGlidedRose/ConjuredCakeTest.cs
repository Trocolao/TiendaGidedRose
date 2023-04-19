using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;

namespace PruebaGlidedRose
{
    [TestClass]
    public class ConjuredCakeTest
    {
        [TestMethod]
        public void ConjuredCakeTest1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 1; i++)
            {
                tienda.UpdateQuality();
            }
            var ConjuredCakeCalidad = Items[0].Quality;
            var ConjuredCakeSellIn = Items[0].SellIn;
            Assert.AreEqual(2, ConjuredCakeSellIn);
            Assert.AreEqual(4, ConjuredCakeCalidad);
        }
        [TestMethod]
        public void ConjuredCakeTest2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 2; i++)
            {
                tienda.UpdateQuality();
            }
            var ConjuredCakeCalidad = Items[0].Quality;
            var ConjuredCakeSellIn = Items[0].SellIn;
            Assert.AreEqual(1, ConjuredCakeSellIn);
            Assert.AreEqual(2, ConjuredCakeCalidad);
        }
        [TestMethod]
        public void ConjuredCakeTest3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 3; i++)
            {
                tienda.UpdateQuality();
            }
            var ConjuredCakeCalidad = Items[0].Quality;
            var ConjuredCakeSellIn = Items[0].SellIn;
            Assert.AreEqual(0, ConjuredCakeSellIn);
            Assert.AreEqual(0, ConjuredCakeCalidad);
        }
        [TestMethod]
        public void ConjuredCakeTest4()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 4; i++)
            {
                tienda.UpdateQuality();
            }
            var ConjuredCakeCalidad = Items[0].Quality;
            var ConjuredCakeSellIn = Items[0].SellIn;
            Assert.AreEqual(-1, ConjuredCakeSellIn);
            Assert.AreEqual(0, ConjuredCakeCalidad);
        }
    }
}
