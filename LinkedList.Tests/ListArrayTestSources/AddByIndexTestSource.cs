using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 7,6 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 7;
            int index = 5;

            yield return new object[] { actuallist, expected, value, index };


            expected = new LinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            value = 7;
            index = 0;

            yield return new object[] { actuallist, expected, value, index };


            expected = new LinkedList(new int[] { 1, 2, 3, -7, 4, 5, 6 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            value = -7;
            index = 3;

            yield return new object[] { actuallist, expected, value, index };
        }
    }
}
