﻿using GildedRose.Program.Items;

namespace GildedRose.Program.QualityCalculators
{
    /// <summary>
    /// Item quality calculator
    /// </summary>
    public interface IItemQualityCalculator
    {
        /// <summary>
        /// Update the quality of an item
        /// </summary>
        /// <param name="item"></param>
        void UpdateQuality(Item item);
    }
}
