using GildedRose.Program.Items;

namespace GildedRose.Program.QualityCalculators
{
    /// <summary>
    /// Base class of an item quality calculator
    /// </summary>
    public abstract class ItemQualityCalculatorBase : IItemQualityCalculator
    {
        /// <summary>
        /// Default tick of quality
        /// </summary>
        protected int _DefaultQualityTick = -1;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"></param>
        public void UpdateQuality(Item item)
        {
            //Legendary items quality doesnt change
            if (!(item is ItemLegendary))
            {
                var tick = item.SellIn < 0 ? _DefaultQualityTick * 2 : _DefaultQualityTick;

                UpdateItemQuality(item, tick);

                //No item can have a quality less than 0
                if (item.Quality < 0)
                    item.Quality = 0;

                //For every item except sulfras the quality limit is 50
                if (item.Quality > 50)
                    item.Quality = 50;
            }
        }

        /// <summary>
        /// Updates item quality
        /// </summary>
        /// <param name="item"></param>
        protected abstract void UpdateItemQuality(Item item, int defaultTick);
    }
}
