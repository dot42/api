using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NUnit.Framework
{
    public class CollectionAssert
    {
        public static void AreEquivalent(IEnumerable expected, IEnumerable actual)
        {
            var a = new List<object>(expected.Cast<object>());
            var b = new List<object>(actual.Cast<object>());

            if(a.Count != b.Count)
                Assert.Fail("expected number of elements: {0}; got {1}", expected, actual);

            foreach(var elem in a)
                if (!b.Contains(elem))
                {
                    Assert.Fail("element not found: {0}", elem);
                }
        }

        public static void AreEqual(IEnumerable expected, IEnumerable actual)
        {
            var a = new List<object>(expected.Cast<object>());
            var b = new List<object>(actual.Cast<object>());

            if (a.Count != b.Count)
                Assert.Fail("expected number of elements: {0}; got {1}", expected, actual);

            for (int i = 0; i < a.Count; ++i)
            {
                Assert.AreEqual(a[i], b[i]);
            }

        }

    }
}
