using GildedRose.Program.Items;

namespace GildedRose.Program.QualityCalculators
{
    public interface IItemQualityCalculatorProvider
    {
        IItemQualityCalculator Provide<T>(T item) where T : Item;
    }
}
