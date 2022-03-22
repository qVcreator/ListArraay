using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class DeleteRangeByIndexTestSourcce : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 1, 2, 3, 6 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int range = 2;
            int index = 3;

            yield return new object[] { actuallist, expected, range, index };


            expected = new ListArray(new int[] { 7, 6, 4 });
            actuallist = new ListArray(new int[] { 7, 6, 2, 3, 4 });
            range = 2;
            index = 2;

            yield return new object[] { actuallist, expected, range, index };


            expected = new ListArray(new int[] { });
            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            range = 6;
            index = 0;

            yield return new object[] { actuallist, expected, range, index };
        }
    }
}
