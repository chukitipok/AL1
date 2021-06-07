using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Xunit;

namespace csharpcore
{
    public class GildedRoseGoldenMaster
    {
        [Fact]
        public void Hello()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                // this conjured item does not work properly yet
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var goldenMaster = File.ReadLines("/Users/mickaelmetesreau/Projects/ESGI/AL1/09-Refactor/exercice/init/goldenmaster.txt").ToArray();
            var app = new GildedRose(Items);
            for (var i = 0; i < 31; i++)
            {
                var day = new List<Item>();
                for (var j = 0; j < Items.Count; j++)
                {
                    day.Add(Items[j]);

                    var line = (Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                    Assert.Equal(goldenMaster[(i * Items.Count) + j], line);
                }

                app.UpdateQuality();
            }
        }
    }
}