﻿using Xunit;
using System.Collections.Generic;
using GildedRose.SellInCalculators;

namespace GildedRose
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items, new ItemSellInCalculator());
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
    }
}