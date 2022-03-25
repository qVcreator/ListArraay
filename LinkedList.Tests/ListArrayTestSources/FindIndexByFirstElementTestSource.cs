using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class FindIndexByFirstElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 3;
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 4;

            yield return new object[] { actuallist, expected, value};


            expected = 0;
            actuallist = new ListArray(new int[] { 7, 6, 2, 3, 4 });
            value = 7;

            yield return new object[] { actuallist, expected, value };


            expected = 5;
            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            value = 6;

            yield return new object[] { actuallist, expected, value };
        }
    }
}
