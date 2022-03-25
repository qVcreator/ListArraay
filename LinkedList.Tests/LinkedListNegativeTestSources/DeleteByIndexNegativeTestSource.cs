using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class DeleteByIndexTest_WhenLengthOfListIsEquaalZero_ShouldThrowExceptionNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { });
            int index = 0;

            yield return new object[] {index, actuallist };


            
        }
    }

    internal class DeleteByIndexTest_WhenIndexOutOfLength_ShouldThrowExceptionNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = -2;

            yield return new object[] { index, actuallist };


            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 6;

            yield return new object[] { index, actuallist };
        }
    }
}
