using System.Collections;
using System.Collections.Generic;

namespace GildedRose.UnitTests
{
    public class ProviderQualityMultipliableTestCases : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Constructors.ItemAgedBrie };
            yield return new object[] { Constructors.ItemBackstagePasses };
            yield return new object[] { Constructors.ItemConjured };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
