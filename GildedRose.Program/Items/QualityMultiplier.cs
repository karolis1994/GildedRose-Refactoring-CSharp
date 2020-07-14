namespace GildedRose.Program.Items
{
    /// <summary>
    /// Quality multiplier
    /// </summary>
    public class QualityTickMultiplier
    {
        public QualityTickMultiplier(int? onSellInReached, int multiplier)
        {
            OnSellInReached = onSellInReached;
            Multiplier = multiplier;
        }

        /// <summary>
        /// When sell in of an item reaches this number or is less than this, multiplier will be applied
        /// When null, always apply the multiplier
        /// </summary>
        public int? OnSellInReached { get; }

        /// <summary>
        /// Multiplier
        /// </summary>
        public int Multiplier { get; }
    }
}
