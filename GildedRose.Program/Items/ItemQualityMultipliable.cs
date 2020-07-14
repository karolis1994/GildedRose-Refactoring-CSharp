using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Program.Items
{
    /// <summary>
    /// Item that can change quality multiplier depending on sellin date reached
    /// </summary>
    public class ItemQualityMultipliable : Item
    {
        public ItemQualityMultipliable(IEnumerable<QualityTickMultiplier> multipliers) : base()
        {
            QualityMultipliers = multipliers.ToList();
        }

        public ItemQualityMultipliable(QualityTickMultiplier multiplier) : base()
        {
            QualityMultipliers = new List<QualityTickMultiplier>{ multiplier };
        }

        /// <summary>
        /// Quality multipliers that change
        /// </summary>
        public List<QualityTickMultiplier> QualityMultipliers { get; set; }
    }
}
