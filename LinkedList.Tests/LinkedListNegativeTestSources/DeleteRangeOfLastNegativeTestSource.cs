using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class DeleteRangeOfLastNegativeTestSource_WhenRnageGreaterThanLength : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int range = 9;

            yield return new object[] { range, actuallist };

        }
    }

    internal class DeleteRangeOfLastNegativeTestSource_WhenRnageLessThanZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int range = -2;

            yield return new object[] { range, actuallist };
        }
    }
}
