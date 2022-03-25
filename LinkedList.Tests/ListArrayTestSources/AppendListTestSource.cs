using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class AppendListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 6, 5, 4, 3, 2, 1 });
            ListArray actuallist = new ListArray(new int[] { 6, 5, 4, 3, 2, 1 });
            ListArray addedList = new ListArray(new int[] { });

            yield return new object[] { addedList, actuallist, expected };


            expected = new ListArray(new int[] { -77, -2, 0, -400, 1, 2, 3 });
            actuallist = new ListArray(new int[] { -77, -2, 0, -400 });
            addedList = new ListArray(new int[] { 1,2,3 });

            yield return new object[] { addedList, actuallist, expected };


            expected = new ListArray(new int[] { 77, 2, 40, 0, 540, -7, -8, 1, 200, 0 });
            actuallist = new ListArray(new int[] { 77, 2, 40, 0, 540 });
            addedList = new ListArray(new int[] { -7,-8,1,200,0 });

            yield return new object[] { addedList, actuallist, expected };
        }
    }
}
