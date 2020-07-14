using GildedRose.Program.Items;
using GildedRose.Program.QualityCalculators;
using GildedRose.Program.SellInCalculators;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly IItemSellInCalculator _SellInCalculator;
        private readonly IItemQualityCalculatorProvider _QualityCalculatorProvider;

        public GildedRose(IList<Item> Items, IItemSellInCalculator sellInCalculator, IItemQualityCalculatorProvider qualityCalculatorProvider)
        {
            this.Items = Items;
            _SellInCalculator = sellInCalculator;
            _QualityCalculatorProvider = qualityCalculatorProvider;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                _SellInCalculator.DecreaseSellIn(Items[i]);
                _QualityCalculatorProvider.Provide(Items[i]).UpdateQuality(Items[i]);
            }
        }
    }
}
