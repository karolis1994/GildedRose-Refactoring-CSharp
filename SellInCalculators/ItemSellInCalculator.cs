using csharpcore.SellInCalculators;
using GildedRose.Items;

namespace GildedRose.SellInCalculators
{
    public class ItemSellInCalculator : IItemSellInCalculator
    {
        public void DecreaseSellIn(Item item)
        {
            if (!item.Name.StartsWith(ItemNames.SulfrasPrefix))
                item.SellIn--;
        }
    }
}
