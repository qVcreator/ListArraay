using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class DeleteRangeOfLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int range = 3;

            yield return new object[] { actuallist, expected, range };


            expected = new LinkedList(new int[] { 7, 6, 2, 3, 4 });
            actuallist = new LinkedList(new int[] { 7, 6, 2, 3, 4 });
            range = 0;

            yield return new object[] { actuallist, expected, range };


            expected = new LinkedList(new int[] { });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            range = 6;

            yield return new object[] { actuallist, expected, range };
        }
    }
}
