using GildedRose.Items;

namespace GildedRose.QualityCalculators
{
    /// <summary>
    /// Item quality calculator
    /// </summary>
    public class ItemQualityCalculator : ItemQualityCalculatorBase
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"></param>
        protected override void UpdateItemQuality(Item item)
        {
            if (item.Name == ItemNames.AgedBrie || (item.Name.StartsWith(ItemNames.BackstagePassesPrefix) && item.SellIn > 10))
                item.Quality++;
            else if (item.Name.StartsWith(ItemNames.ConjuredPrefix))
                item.Quality -= 2;
            else if (item.Name.StartsWith(ItemNames.BackstagePassesPrefix))
            {
                if (item.SellIn <= 10 && item.SellIn > 5)
                    item.Quality += 2;
                else if (item.SellIn > 0)
                    item.Quality += 3;
                else
                    item.Quality = 0;
            }
            else if (!item.Name.StartsWith(ItemNames.SulfrasPrefix))
                item.Quality--;
        }
    }
}
