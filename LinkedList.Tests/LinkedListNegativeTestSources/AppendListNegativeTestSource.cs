using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class NegativeTestSource_WhenListIsNull : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] {1,2,3,4,5 });
            LinkedList addedList = null;

            yield return new object[] { addedList, actuallist };
        }
    }

    internal class NegativeTestSource_WhenListIsEmpty : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList addedList = new LinkedList();

            yield return new object[] { addedList, actuallist };
        }
    }
}
