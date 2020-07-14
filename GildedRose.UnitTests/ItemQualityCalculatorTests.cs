using GildedRose.Program.QualityCalculators;
using Xunit;

namespace GildedRose.UnitTests
{
    public class ItemQualityCalculatorTests
    {
        [Fact]
        public void UpdateQuality_ItemRegular_DoesntGoBelowZero()
        {
            //Arrange
            var item = Constructors.Item;
            item.Quality = Constants.Zero;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero, item.Quality);
        }

        [Fact]
        public void UpdateQuality_ItemRegular_DecreasesByOne()
        {
            //Arrange
            var item = Constructors.Item;
            item.Quality = Constants.Ten;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Ten - 1, item.Quality);
        }

        [Fact]
        public void UpdateQuality_ConjuredItem_DoesntGoBelowZero()
        {
            //Arrange
            var item = Constructors.ItemConjured;
            item.Quality = Constants.Zero;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero, item.Quality);
        }

        [Fact]
        public void UpdateQuality_ConjuredItem_DecreasesByTwo()
        {
            //Arrange
            var item = Constructors.ItemConjured;
            item.Quality = Constants.Ten;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Ten - 2, item.Quality);
        }

        [Fact]
        public void UpdateQuality_AgedBrie_DoesntGoAbove50()
        {
            //Arrange
            var item = Constructors.ItemAgedBrie;
            item.Quality = 50;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void UpdateQuality_AgedBrie_IncreasesByOne()
        {
            //Arrange
            var item = Constructors.ItemAgedBrie;
            item.Quality = Constants.Zero;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero + 1, item.Quality);
        }

        [Fact]
        public void UpdateQuality_LegendaryItem_DoesntChange()
        {
            //Arrange
            var item = Constructors.ItemLegendary;
            item.Quality = 80;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(80, item.Quality);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(20)]
        [InlineData(30)]
        [InlineData(100)]
        [InlineData(1100)]
        public void UpdateQuality_BackstagePasses_IncreasesByOne(int sellIn)
        {
            //Arrange
            var item = Constructors.ItemBackstagePasses;
            item.SellIn = sellIn;
            item.Quality = Constants.Zero;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero + 1, item.Quality);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        public void UpdateQuality_BackstagePasses_IncreasesByTwo(int sellIn)
        {
            //Arrange
            var item = Constructors.ItemBackstagePasses;
            item.SellIn = sellIn;
            item.Quality = Constants.Zero;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero + 2, item.Quality);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(0)]
        public void UpdateQuality_BackstagePasses_IncreasesByThree(int sellIn)
        {
            //Arrange
            var item = Constructors.ItemBackstagePasses;
            item.SellIn = sellIn;
            item.Quality = Constants.Zero;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero + 3, item.Quality);
        }

        [Fact]
        public void UpdateQuality_BackstagePasses_RevertsToZero()
        {
            //Arrange
            var item = Constructors.ItemBackstagePasses;
            item.SellIn = -1;
            item.Quality = Constants.Ten;
            var qualityCalculator = new ItemQualityCalculator();

            //Act
            qualityCalculator.UpdateQuality(item);

            //Assert
            Assert.Equal(Constants.Zero, item.Quality);
        }
    }
}
