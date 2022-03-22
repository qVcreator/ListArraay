using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 6,5,4,3,2,1 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { actuallist, expected };


            expected = new ListArray(new int[] { -77});
            actuallist = new ListArray(new int[] { -77 });

            yield return new object[] { actuallist, expected };


            expected = new ListArray(new int[] { });
            actuallist = new ListArray(new int[] { });

            yield return new object[] { actuallist, expected };
        }
    }
}
