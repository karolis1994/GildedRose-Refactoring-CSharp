using GildedRose.Items;

namespace GildedRose.UnitTests
{
    public class Constructors
    {
        public static Item Item => new Item()
        {
            Name = Constants.RegularItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static Item ItemLegendary => new Item()
        {
            Name = Constants.LegendaryItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static Item ItemConjured => new Item()
        {
            Name = Constants.ConjuredItemName,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static Item ItemAgedBrie => new Item()
        {
            Name = ItemNames.AgedBrie,
            Quality = 0,
            SellIn = Constants.Ten
        };

        public static Item ItemBackstagePasses => new Item()
        {
            Name = ItemNames.BackstagePassesPrefix + "test",
            Quality = 0,
            SellIn = Constants.Ten
        };
    }
}
