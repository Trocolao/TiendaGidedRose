using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
            int bajadaCalidad;
            for (var i = 0; i < Items.Count; i++)
            {
                if (EsMagico(Items[i]))
                {
                    bajadaCalidad = 2;
                    DescensoDeLaCalidad(Items[i], bajadaCalidad);
                }
                else
                {
                    bajadaCalidad = 1;
                    DescensoDeLaCalidad(Items[i], bajadaCalidad);
                }
            }
        }
        private void DescensoDeLaCalidad(Item item, int bajadaCalidad)
        {
            ActualizarCalidadConSellInPositivo(item, bajadaCalidad);
            ActualizarSellIn(item);
            ActualizarCalidadConSellInNegativo(item, bajadaCalidad);
        }

        private void ActualizarCalidadConSellInNegativo(Item item, int bajadaCalidad)
        {
            if (item.SellIn < 0)
            {
                if(item.Name == "Aged Brie")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.Quality = item.Quality - item.Quality;
                }
                else
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            item.Quality = item.Quality - bajadaCalidad;
                        }
                    }
                }
            }
        }

        private void ActualizarSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        private void ActualizarCalidadConSellInPositivo(Item item, int bajadaCalidad)
        {
            if (item.Name == "Aged Brie" || item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                    ActualizarCalidadDeUnConciertoReciente(item);
                }
            }
            else
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.Quality = item.Quality - bajadaCalidad;
                    }
                }
            }
        }

        private void ActualizarCalidadDeUnConciertoReciente(Item item)
        {
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }
}