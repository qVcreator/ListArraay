using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int num = 7;

            yield return new object[] { actuallist, expected, num };


            expected = new ListArray(new int[] {7});
            actuallist = new ListArray(new int[0] { });
            num = 7;

            yield return new object[] { actuallist, expected, num };


            expected = new ListArray(new int[] { 1, 2, 3, 4, 5, 6,-7});
            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            num = -7;

            yield return new object[] { actuallist, expected, num };
        }
    }
}
