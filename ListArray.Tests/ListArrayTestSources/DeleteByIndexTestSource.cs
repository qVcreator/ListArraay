using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 5;

            yield return new object[] { actuallist, expected, index };


            expected = new ListArray(new int[] { 6, 2, 3, 4 });
            actuallist = new ListArray(new int[] { 7,6,2,3,4 });
            index = 0;

            yield return new object[] { actuallist, expected, index };


            expected = new ListArray(new int[] { 1, 2, 3, 4, 6 });
            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 4;

            yield return new object[] { actuallist, expected, index };
        }
    }
}
