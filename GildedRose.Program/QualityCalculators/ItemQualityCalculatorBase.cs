using GildedRose.Items;

namespace GildedRose.QualityCalculators
{
    /// <summary>
    /// Base class of an item quality calculator
    /// </summary>
    public abstract class ItemQualityCalculatorBase : IItemQualityCalculator
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"></param>
        public void UpdateQuality(Item item)
        {
            UpdateItemQuality(item);

            //No item can have a quality less than 0
            if (item.Quality < 0)
                item.Quality = 0;
        }

        /// <summary>
        /// Updates item quality
        /// </summary>
        /// <param name="item"></param>
        protected abstract void UpdateItemQuality(Item item);
    }
}
