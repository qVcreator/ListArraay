using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class DeleteRangeOfFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 4, 5, 6 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int range = 3;

            yield return new object[] { actuallist, expected, range };


            expected = new ListArray(new int[] { 7, 6, 2, 3, 4 });
            actuallist = new ListArray(new int[] { 7, 6, 2, 3, 4 });
            range = 0;

            yield return new object[] { actuallist, expected, range };


            expected = new ListArray(new int[] { });
            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            range = 6;

            yield return new object[] { actuallist, expected, range };
        }
    }
}
