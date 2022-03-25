using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 6;
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { actuallist, expected };


            expected = 0;
            actuallist = new ListArray(new int[] { -77, -2, -40,0 });

            yield return new object[] { actuallist, expected };


            expected = 540;
            actuallist = new ListArray(new int[] { -77, -2, -40, 0, 540 });

            yield return new object[] { actuallist, expected };
        }
    }
}
