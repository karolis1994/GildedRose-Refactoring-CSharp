using GildedRose.QualityCalculators;
using System.Reflection.Metadata;
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
    }
}
