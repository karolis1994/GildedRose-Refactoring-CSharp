using GildedRose.Program.Items;
using System;
using System.Collections.Generic;

namespace GildedRose.Program.QualityCalculators
{
    /// <summary>
    /// Provider to retrieve quality calculator depending on class type
    /// </summary>
    public class ItemQualityCalculatorProvider : IItemQualityCalculatorProvider
    {
        private static Dictionary<Type, IItemQualityCalculator> qualityCalculators
            = new Dictionary<Type, IItemQualityCalculator>()
            {
                { typeof(ItemQualityMultipliable), new ItemQualityMultipliableQualityCalculator() },
                { typeof(ItemConjured), new ItemQualityMultipliableQualityCalculator() },
                { typeof(ItemBackstagePasses), new ItemQualityMultipliableQualityCalculator() },
                { typeof(ItemRegular), new ItemQualityCalculator() },
            };

        public IItemQualityCalculator Provide<T>(T item) where T : Item
        {
            if (!qualityCalculators.TryGetValue(item.GetType(), out var qualityCalculator))
                return qualityCalculators[typeof(ItemRegular)];

            return qualityCalculator;
        }
    }
}
