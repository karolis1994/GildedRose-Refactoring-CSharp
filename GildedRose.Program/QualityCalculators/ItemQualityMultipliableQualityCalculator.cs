using GildedRose.Program.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Program.QualityCalculators
{
    public class ItemQualityMultipliableQualityCalculator : ItemQualityCalculatorBase
    {
        protected override void UpdateItemQuality(Item item, int tick)
        {
            UpdateItemQuality((ItemQualityMultipliable) item, tick);
        }

        private void UpdateItemQuality(ItemQualityMultipliable item, int tick)
        {
            var changedTick = tick;
            var multiplier = item.QualityMultipliers
                .Where(e => e.OnSellInReached == null || e.OnSellInReached >= item.SellIn)
                .OrderByDescending(e => e.OnSellInReached.HasValue)
                .ThenBy(e => e.OnSellInReached)
                .FirstOrDefault();

            if (multiplier != null)
            {
                changedTick *= multiplier.Multiplier;
            }

            item.Quality += changedTick;
        }
    }
}
