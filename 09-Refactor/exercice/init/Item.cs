namespace csharpcore
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void DecrementSellIn()
        {
            if (this.Name != "Sulfuras, Hand of Ragnaros")
            {
                this.SellIn = this.SellIn - 1;
            }
        }

        public void DecrementQuality()
        {
            if (this.Quality > 0)
            {
                if (this.Name != "Sulfuras, Hand of Ragnaros")
                {
                    this.Quality = this.Quality - 1;
                }
            }
        }

        public void IncrementQuality()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;
            }
        }

        public static IUpdateItem CreateUpdateCommand(string name)
        {
            return name switch
            {
                "Aged Brie" => new UpdateAgedBrie(),
                "Backstage passes to a TAFKAL80ETC concert" => new UpdateBackstage(),
                _ => new UpdateCommonItem()
            };
        }
    }
}