using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlidedRose;
using System.Collections.Generic;

namespace PruebaGlidedRose
{
    [TestClass]
    public class UnitTest1
    {
        IList<Item> Items = new List<Item> {  new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                  new Item {Name = "+5 Dexterity Vest conjured", SellIn = 10, Quality = 20},
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15,Quality = 20},
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 10,Quality = 49},
                 new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 5,Quality = 49},
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        [TestMethod]
        public void TestMethod1()
        {
            Tienda tienda = new Tienda(Items);
            tienda.UpdateQuality();
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(1, item0sellin);
            Assert.AreEqual(1, item0calidad);
            Assert.AreEqual(4, item1sellin);
            Assert.AreEqual(6, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(9, item4sellin);
            Assert.AreEqual(18, item4calidad);
            Assert.AreEqual(14, item5sellin);
            Assert.AreEqual(21, item5calidad);
            Assert.AreEqual(9, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(4, item7sellin);
            Assert.AreEqual(50, item7calidad);
            Assert.AreEqual(2, item8sellin);
            Assert.AreEqual(4, item8calidad);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 2; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(0, item0sellin);
            Assert.AreEqual(2, item0calidad);
            Assert.AreEqual(3, item1sellin);
            Assert.AreEqual(5, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(8, item4sellin);
            Assert.AreEqual(16, item4calidad);
            Assert.AreEqual(13, item5sellin);
            Assert.AreEqual(22, item5calidad);
            Assert.AreEqual(8, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(3, item7sellin);
            Assert.AreEqual(50, item7calidad);
            Assert.AreEqual(1, item8sellin);
            Assert.AreEqual(2, item8calidad);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 3; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-1, item0sellin);
            Assert.AreEqual(4, item0calidad);
            Assert.AreEqual(2, item1sellin);
            Assert.AreEqual(4, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(7, item4sellin);
            Assert.AreEqual(14, item4calidad);
            Assert.AreEqual(12, item5sellin);
            Assert.AreEqual(23, item5calidad);
            Assert.AreEqual(7, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(2, item7sellin);
            Assert.AreEqual(50, item7calidad);
            Assert.AreEqual(0, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 4; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-2, item0sellin);
            Assert.AreEqual(6, item0calidad);
            Assert.AreEqual(1, item1sellin);
            Assert.AreEqual(3, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(6, item4sellin);
            Assert.AreEqual(12, item4calidad);
            Assert.AreEqual(11, item5sellin);
            Assert.AreEqual(24, item5calidad);
            Assert.AreEqual(6, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(1, item7sellin);
            Assert.AreEqual(50, item7calidad);
            Assert.AreEqual(-1, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 5; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-3, item0sellin);
            Assert.AreEqual(8, item0calidad);
            Assert.AreEqual(0, item1sellin);
            Assert.AreEqual(2, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(5, item4sellin);
            Assert.AreEqual(10, item4calidad);
            Assert.AreEqual(10, item5sellin);
            Assert.AreEqual(25, item5calidad);
            Assert.AreEqual(5, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(0, item7sellin);
            Assert.AreEqual(50, item7calidad);
            Assert.AreEqual(-2, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 6; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-4, item0sellin);
            Assert.AreEqual(10, item0calidad);
            Assert.AreEqual(-1, item1sellin);
            Assert.AreEqual(0, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(4, item4sellin);
            Assert.AreEqual(8, item4calidad);
            Assert.AreEqual(9, item5sellin);
            Assert.AreEqual(27, item5calidad);
            Assert.AreEqual(4, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(-1, item7sellin);
            Assert.AreEqual(0, item7calidad);
            Assert.AreEqual(-3, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 7; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-5, item0sellin);
            Assert.AreEqual(12, item0calidad);
            Assert.AreEqual(-2, item1sellin);
            Assert.AreEqual(0, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(3, item4sellin);
            Assert.AreEqual(6, item4calidad);
            Assert.AreEqual(8, item5sellin);
            Assert.AreEqual(29, item5calidad);
            Assert.AreEqual(3, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(-2, item7sellin);
            Assert.AreEqual(0, item7calidad);
            Assert.AreEqual(-4, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 8; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-6, item0sellin);
            Assert.AreEqual(14, item0calidad);
            Assert.AreEqual(-3, item1sellin);
            Assert.AreEqual(0, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(2, item4sellin);
            Assert.AreEqual(4, item4calidad);
            Assert.AreEqual(7, item5sellin);
            Assert.AreEqual(31, item5calidad);
            Assert.AreEqual(2, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(-3, item7sellin);
            Assert.AreEqual(0, item7calidad);
            Assert.AreEqual(-5, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Tienda tienda = new Tienda(Items);
            for (int i = 0; i < 9; i++)
            {
                tienda.UpdateQuality();
            }
            var item0calidad = Items[0].Quality;
            var item0sellin = Items[0].SellIn;
            var item1calidad = Items[1].Quality;
            var item1sellin = Items[1].SellIn;
            var item2calidad = Items[2].Quality;
            var item2sellin = Items[2].SellIn;
            var item3calidad = Items[3].Quality;
            var item3sellin = Items[3].SellIn;
            var item4calidad = Items[4].Quality;
            var item4sellin = Items[4].SellIn;
            var item5calidad = Items[5].Quality;
            var item5sellin = Items[5].SellIn;
            var item6calidad = Items[6].Quality;
            var item6sellin = Items[6].SellIn;
            var item7calidad = Items[7].Quality;
            var item7sellin = Items[7].SellIn;
            var item8calidad = Items[8].Quality;
            var item8sellin = Items[8].SellIn;
            Assert.AreEqual(-7, item0sellin);
            Assert.AreEqual(16, item0calidad);
            Assert.AreEqual(-4, item1sellin);
            Assert.AreEqual(0, item1calidad);
            Assert.AreEqual(0, item2sellin);
            Assert.AreEqual(80, item2calidad);
            Assert.AreEqual(-1, item3sellin);
            Assert.AreEqual(80, item3calidad);
            Assert.AreEqual(1, item4sellin);
            Assert.AreEqual(2, item4calidad);
            Assert.AreEqual(6, item5sellin);
            Assert.AreEqual(33, item5calidad);
            Assert.AreEqual(1, item6sellin);
            Assert.AreEqual(50, item6calidad);
            Assert.AreEqual(-4, item7sellin);
            Assert.AreEqual(0, item7calidad);
            Assert.AreEqual(-6, item8sellin);
            Assert.AreEqual(0, item8calidad);
        }
    }
}
