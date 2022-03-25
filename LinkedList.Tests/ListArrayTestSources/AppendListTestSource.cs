using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class AppendListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1 });
            LinkedList actuallist = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1 });
            LinkedList addedList = new LinkedList(new int[] { });

            yield return new object[] { addedList, actuallist, expected };


            expected = new LinkedList(new int[] { -77, -2, 0, -400, 1, 2, 3 });
            actuallist = new LinkedList(new int[] { -77, -2, 0, -400 });
            addedList = new LinkedList(new int[] { 1,2,3 });

            yield return new object[] { addedList, actuallist, expected };


            expected = new LinkedList(new int[] { 77, 2, 40, 0, 540, -7, -8, 1, 200, 0 });
            actuallist = new LinkedList(new int[] { 77, 2, 40, 0, 540 });
            addedList = new LinkedList(new int[] { -7,-8,1,200,0 });

            yield return new object[] { addedList, actuallist, expected };
        }
    }
}
