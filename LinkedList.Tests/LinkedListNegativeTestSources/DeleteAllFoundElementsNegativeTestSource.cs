using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class DeleteAllFoundElementsNegativeTest_WhenLengthIsEqualsZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { });
            int value = 5;

            yield return new object[] { value, actuallist };
        }
    }
}
