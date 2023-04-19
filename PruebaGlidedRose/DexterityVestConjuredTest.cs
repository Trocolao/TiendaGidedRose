using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;

namespace PruebaGlidedRose
{
    [TestClass]
    public class DexterityVestConjuredTest
    {
        [TestMethod]
        public void DexterityVestCojuredTestMethod1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest conjured", SellIn = 10, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 1; i++)
            {
                tienda.UpdateQuality();
            }
            var DexterityCalidad = Items[0].Quality;
            var DexteritySellIn = Items[0].SellIn;
            Assert.AreEqual(9, DexteritySellIn);
            Assert.AreEqual(18, DexterityCalidad);
        }
        [TestMethod]
        public void DexterityVestCojuredTestMethod2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest conjured", SellIn = 10, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 5; i++)
            {
                tienda.UpdateQuality();
            }
            var DexterityCalidad = Items[0].Quality;
            var DexteritySellIn = Items[0].SellIn;
            Assert.AreEqual(5, DexteritySellIn);
            Assert.AreEqual(10, DexterityCalidad);
        }
        [TestMethod]
        public void DexterityVestCojuredTestMethod3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest conjured", SellIn = 10, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 10; i++)
            {
                tienda.UpdateQuality();
            }
            var DexterityCalidad = Items[0].Quality;
            var DexteritySellIn = Items[0].SellIn;
            Assert.AreEqual(0, DexteritySellIn);
            Assert.AreEqual(0, DexterityCalidad);
        }
        [TestMethod]
        public void DexterityVestCojuredTestMethod4()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest conjured", SellIn = 10, Quality = 20 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 11; i++)
            {
                tienda.UpdateQuality();
            }
            var DexterityCalidad = Items[0].Quality;
            var DexteritySellIn = Items[0].SellIn;
            Assert.AreEqual(-1, DexteritySellIn);
            Assert.AreEqual(0, DexterityCalidad);
        }
    }
}
