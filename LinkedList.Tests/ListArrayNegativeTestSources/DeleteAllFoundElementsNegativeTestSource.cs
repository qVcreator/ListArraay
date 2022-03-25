using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayNegativeTestSources
{
    internal class DeleteAllFoundElementsNegativeTest_WhenLengthIsEqualsZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray actuallist = new ListArray(new int[] { });
            int value = 5;

            yield return new object[] { value, actuallist };
        }
    }
}
