using System;
using System.Collections.Generic;
using System.Text;

namespace GlidedRose
{
    internal class Tienda
    {
        IList<Item> Items;
        public Tienda(IList<Item> Items)
        {
            this.Items = Items;
        }
        public bool EsMagico(Item item)
        {
            string nombre = item.Name.ToLower();
            if (nombre.Contains("conjured"))
            {
                return true;
            }

            return false;
        }

        public void UpdateQuality()
        {
            int bajadaCalidad = 1;
            for (var i = 0; i < Items.Count; i++)
            {
                if (EsMagico(Items[i]))
                {
                    bajadaCalidad = 2;
                    DescensoDeLaCalidad(i, bajadaCalidad);
                }
                else
                {
                    DescensoDeLaCalidad(i, bajadaCalidad);
                }
            }
        }
        private void DescensoDeLaCalidad(int i, int bajadaCalidad)
        {
            ActualizarCalidadConSellInPositivo(i, bajadaCalidad);
            ActualizarSellIn(i);
            ActualizarCalidadConSellInNegativo(i, bajadaCalidad);
        }

        private void ActualizarCalidadConSellInNegativo(int i, int bajadaCalidad)
        {
            if (Items[i].SellIn < 0)
            {
                if(Items[i].Name == "Aged Brie")
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
                }
                else
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - bajadaCalidad;
                        }
                    }
                }
            }
        }

        private void ActualizarSellIn(int i)
        {
            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }
        }

        private void ActualizarCalidadConSellInPositivo(int i, int bajadaCalidad)
        {
            if (Items[i].Name == "Aged Brie" || Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[i].Quality < 50)
                {
                    Items[i].Quality = Items[i].Quality + 1;
                    ActualizarCalidadDeUnConciertoReciente(i);
                }
            }
            else
            {
                if (Items[i].Quality > 0)
                {
                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].Quality = Items[i].Quality - bajadaCalidad;
                    }
                }
            }
        }

        private void ActualizarCalidadDeUnConciertoReciente(int i)
        {
            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[i].SellIn < 11)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
                if (Items[i].SellIn < 6)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
            }
        }
    }
}