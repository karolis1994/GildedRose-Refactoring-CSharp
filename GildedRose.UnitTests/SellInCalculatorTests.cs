using GildedRose.Program.SellInCalculators;
using Xunit;

namespace GildedRose.UnitTests
{
    public class SellInCalculatorTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(-10)]
        public void DecreaseSellIn_Item(int sellIn)
        {
            //Arrange
            var item = Constructors.Item;
            item.SellIn = sellIn;
            var sellInCalculator = new ItemSellInCalculator();

            //Act
            sellInCalculator.DecreaseSellIn(item);

            //Assert
            Assert.Equal(sellIn - 1, item.SellIn);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(-10)]
        public void DecreaseSellIn_ItemLegendary_SellInDoesntChange(int sellIn)
        {
            //Arrange
            var item = Constructors.ItemLegendary;
            item.SellIn = sellIn;
            var sellInCalculator = new ItemSellInCalculator();

            //Act
            sellInCalculator.DecreaseSellIn(item);

            //Assert
            Assert.Equal(sellIn, item.SellIn);
        }
    }
}
