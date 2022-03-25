using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class ChangeElementByindexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 1, 2, 3, 5, 5, 6 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 5;
            int index = 3;

            yield return new object[] { index, value, actuallist, expected };


            expected = new ListArray(new int[] { -77, 2, 3, 4, 5 });
            actuallist = new ListArray(new int[] { 7, 2, 3, 4, 5 });
            value = -77;
            index = 0;

            yield return new object[] { index, value, actuallist, expected };


            expected = new ListArray(new int[] { 1, 2, 3, 4, 5, 0 });
            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            value =0;
            index = 5;

            yield return new object[] { index, value, actuallist, expected };
        }
    }
}
