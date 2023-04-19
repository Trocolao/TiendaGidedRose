using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;
namespace PruebaGlidedRose
{
    [TestClass]
    public class SulfurasTest
    {
        [TestMethod]
        public void SulfurasTestMethod1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 5; i++)
            {
                tienda.UpdateQuality();
            }
            var SulfurasCalidad = Items[0].Quality;
            var SulfurasSellIn = Items[0].SellIn;
            Assert.AreEqual(0, SulfurasSellIn);
            Assert.AreEqual(80, SulfurasCalidad);
        }
    }
}
