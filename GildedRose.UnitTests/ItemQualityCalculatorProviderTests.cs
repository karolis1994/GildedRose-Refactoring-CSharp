using GildedRose.Program.Items;
using GildedRose.Program.QualityCalculators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRose.UnitTests
{
    public class ItemQualityCalculatorProviderTests
    {
        [Theory]
        [ClassData(typeof(ProviderQualityMultipliableTestCases))]
        public void Provide_ItemQualityMultipliableQualityCalculator(ItemQualityMultipliable item)
        {
            //Arrange
            var provider = new ItemQualityCalculatorProvider();

            //Act
            var calculator = provider.Provide(item);

            //Assert
            Assert.Equal(typeof(ItemQualityMultipliableQualityCalculator), calculator.GetType());
        }

        [Theory]
        [ClassData(typeof(ProviderTestCases))]
        public void Provide_ItemQualityCalculator(Item item)
        {
            //Arrange
            var provider = new ItemQualityCalculatorProvider();

            //Act
            var calculator = provider.Provide(item);

            //Assert
            Assert.Equal(typeof(ItemQualityCalculator), calculator.GetType());
        }
    }
}
