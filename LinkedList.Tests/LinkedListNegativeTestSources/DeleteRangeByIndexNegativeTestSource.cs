using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class DeleteRangeByIndexNegativeTestSource_WhenIndexOutOfRange : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = -1;
            int range = 2;

            yield return new object[] { index,range, actuallist };
        }
    }

    internal class DeleteRangeByIndexNegativeTestSource_WhenRangeGreaterThanLength : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 2;
            int range = 7;

            yield return new object[] { index, range, actuallist };
        }
    }

    internal class DeleteRangeByIndexNegativeTestSource_WhenRangeLessThanZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 2;
            int range = -2;

            yield return new object[] { index, range, actuallist };
        }
    }

}