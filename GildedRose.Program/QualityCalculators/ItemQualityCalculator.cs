using GildedRose.Program.Items;

namespace GildedRose.Program.QualityCalculators
{
    /// <summary>
    /// Standard item quality calculator
    /// </summary>
    public sealed class ItemQualityCalculator : ItemQualityCalculatorBase
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"></param>
        protected override void UpdateItemQuality(Item item, int tick)
        {
            item.Quality += tick;
        }
    }
}
