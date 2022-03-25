using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class SortBiggerLessTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 6, 5, 4, 3, 2, 1 });
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            
            yield return new object[] { actuallist, expected };


            expected = new ListArray(new int[] { 0,-2,-77,-400 });
            actuallist = new ListArray(new int[] { -77, -2, 0, -400 });

            yield return new object[] { actuallist, expected };


            expected = new ListArray(new int[] { 540,77,40,2,0 });
            actuallist = new ListArray(new int[] { 77, 2, 40, 0, 540 });

            yield return new object[] { actuallist, expected };
        }
    }
}
