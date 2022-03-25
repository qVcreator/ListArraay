using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayNegativeTestSources
{
    internal class ChangeElementByindexNegativeTestSource_WhenLengthIsEqualsZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray actuallist = new ListArray(new int[] { });
            int index = 1;
            int value = 2;

            yield return new object[] { index, value, actuallist };
        }
    }

    internal class ChangeElementByindexNegativeTestSource_WhenIndexOutOfLength : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = -1;
            int value = 2;

            yield return new object[] { index, value, actuallist };

            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 9;
            value = 2;

            yield return new object[] { index, value, actuallist };
        }
    }
}