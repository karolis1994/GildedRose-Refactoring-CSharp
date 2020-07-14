using System.Collections.Generic;

namespace GildedRose.Program.Items
{
    /// <summary>
    /// Item backstage passes
    /// </summary>
    public sealed class ItemBackstagePasses : ItemQualityMultipliable
    {
        public ItemBackstagePasses() : base(GetQualityMultipliers()) { }

        private static IEnumerable<QualityTickMultiplier> GetQualityMultipliers()
        {
            yield return new QualityTickMultiplier(null, -1);
            yield return new QualityTickMultiplier(10, -2);
            yield return new QualityTickMultiplier(5, -3);
            yield return new QualityTickMultiplier(-1, 100);
        }
    }
}
