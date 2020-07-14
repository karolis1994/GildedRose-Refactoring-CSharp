using GildedRose.Program.SellInCalculators;
using GildedRose.Program.Items;

namespace GildedRose.Program.SellInCalculators
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
