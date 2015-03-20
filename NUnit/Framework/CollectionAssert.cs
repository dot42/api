using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NUnit.Framework
{
    public class CollectionAssert
    {
        public static void AreEquivalent(ICollection expected, ICollection actual)
        {
            if(expected.Count != actual.Count)
                Assert.Fail("expected number of elements: {0}; got {1}", expected, actual);

            var listActual = new List<object>(actual.Cast<object>());
            foreach(var elem in expected.Cast<object>())
                if (!listActual.Contains(elem))
                {
                    Assert.Fail("element not found: {0}", elem);
                }
        }
    }
}
