using GildedRose;

namespace csharpcore.SellInCalculators
{
    /// <summary>
    /// Item sell in calculator
    /// </summary>
    public interface IItemSellInCalculator
    {
        /// <summary>
        /// Decrease the sell in value
        /// </summary>
        /// <param name="item"></param>
        void DecreaseSellIn(Item item);
    }
}
