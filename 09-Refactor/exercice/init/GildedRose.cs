using System.Collections.Generic;

namespace csharpcore
{
    public interface IUpdateItem
    {
        void Update(Item item);
    }
    
    public class UpdateAgedBrie : IUpdateItem
    {
        public void Update(Item item)
        {
            item.IncrementQuality();
                
            item.DecrementSellIn();
                
            if (item.SellIn < 0) item.IncrementQuality();
        }
    }

    public class UpdateBackstage : IUpdateItem
    {
        public void Update(Item item)
        {
            item.IncrementQuality();

            if (item.SellIn <= 10)
                item.IncrementQuality();

            if (item.SellIn <= 5)
                item.IncrementQuality();
                
            item.DecrementSellIn();
                
            if (item.SellIn < 0)
                item.Quality = 0;
        }
    }

    public class UpdateCommonItem : IUpdateItem
    {
        public void Update(Item item)
        {
            item.DecrementQuality();
                
            item.DecrementSellIn();
                
            if (item.SellIn < 0) item.DecrementQuality();
        }
    }

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


        private static void UpdateQualityItem(Item item)
        {
            IUpdateItem cmd = Item.CreateUpdateCommand(item.Name);
          
            cmd.Update(item);
        }

     
    }
}