using System.Collections;
using System.Collections.Generic;

namespace GildedRose.UnitTests
{
    public class ProviderTestCases : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Constructors.Item };
            yield return new object[] { Constructors.ItemLegendary };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
