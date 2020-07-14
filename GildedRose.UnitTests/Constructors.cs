using GildedRose.Program.Items;

namespace GildedRose.UnitTests
{
    public class Constructors
    {
        public static Item Item => new Item()
        {
            Name = Constants.ItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static ItemLegendary ItemLegendary => new ItemLegendary()
        {
            Name = Constants.ItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static Item ItemConjured => new ItemConjured()
        {
            Name = Constants.ItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static ItemQualityMultipliable ItemAgedBrie => new ItemQualityMultipliable(new QualityTickMultiplier(null, -1))
        {
            Name = Constants.ItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static Item ItemBackstagePasses => new ItemBackstagePasses()
        {
            Name = Constants.ItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };
    }
}
