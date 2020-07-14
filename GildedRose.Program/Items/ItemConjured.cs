using System.Collections.Generic;

namespace GildedRose.Program.Items
{
    /// <summary>
    /// Item conjured
    /// </summary>
    public sealed class ItemConjured : ItemQualityMultipliable
    {
        public ItemConjured() : base(GetQualityMultipliers()) { }

        private static IEnumerable<QualityTickMultiplier> GetQualityMultipliers()
        {
            yield return new QualityTickMultiplier(null, 2);
        }
    }
}
