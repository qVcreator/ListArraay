using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class AddByIndexNegativeTestSource: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 7;
            int index = -2;

            yield return new object[] { actuallist, value, index };


            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            value = 7;
            index = 6;

            yield return new object[] { actuallist, value, index };
        }
    }
}
