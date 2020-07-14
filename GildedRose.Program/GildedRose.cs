using GildedRose.Program.SellInCalculators;
using GildedRose.Program.QualityCalculators;
using System.Collections.Generic;
using GildedRose.Program.Items;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly IItemSellInCalculator _SellInCalculator;
        private readonly IItemQualityCalculator _QualityCalculator;

        public GildedRose(IList<Item> Items, IItemSellInCalculator sellInCalculator, IItemQualityCalculator qualityCalculator)
        {
            this.Items = Items;
            _SellInCalculator = sellInCalculator;
            _QualityCalculator = qualityCalculator;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                _SellInCalculator.DecreaseSellIn(Items[i]);
                _QualityCalculator.UpdateQuality(Items[i]);
            }
        }
    }
}
