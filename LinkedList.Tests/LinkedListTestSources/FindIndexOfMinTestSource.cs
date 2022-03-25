using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class FindIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 0;
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { actuallist, expected };


            expected = 3;
            actuallist = new LinkedList(new int[] { -77, -2, 0, -400 });

            yield return new object[] { actuallist, expected };


            expected = 3;
            actuallist = new LinkedList(new int[] { 77, 2, 40, 0, 540 });

            yield return new object[] { actuallist, expected };
        }
    }
}
