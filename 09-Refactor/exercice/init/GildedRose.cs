using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateQualityItem(item);
            }
        }

        private const int minQualityValue = 0;

        private static void UpdateQualityItem(Item item)
        {
            if (item.Name == "Aged Brie" || item.Name == "Backstage passes to a TAFKAL80ETC concert")
                IncrementQuality(item);
            else
                DecrementQuality(item);

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn <= 10)
                    IncrementQuality(item);

                if (item.SellIn <= 5)
                    IncrementQuality(item);
            }

            DecrementSellIn(item);

            if (item.SellIn < 0)
            {
                if (item.Name == "Aged Brie")
                {
                    IncrementQuality(item);
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.Quality = minQualityValue;
                }
                else
                {
                    DecrementQuality(item);
                }
            }
        }

        private static void DecrementSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        private static void DecrementQuality(Item item)
        {
            if (item.Quality > 0)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }

        private static void IncrementQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}