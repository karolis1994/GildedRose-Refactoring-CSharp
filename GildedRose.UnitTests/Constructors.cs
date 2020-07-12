namespace GildedRose.UnitTests
{
    public class Constructors
    {
        public static Item Item => new Item()
        {
            Name = Constants.RegularItemName,
            Quality = 0,
            SellIn = Constants.RegularItemSellIn
        };

        public static Item ItemLegendary => new Item()
        {
            Name = Constants.LegendaryItemName,
            Quality = 0,
            SellIn = Constants.RegularItemSellIn
        };
    }
}
