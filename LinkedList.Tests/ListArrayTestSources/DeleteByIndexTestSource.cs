using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 5;

            yield return new object[] { actuallist, expected, index };


            expected = new LinkedList(new int[] { 6, 2, 3, 4 });
            actuallist = new LinkedList(new int[] { 7,6,2,3,4 });
            index = 0;

            yield return new object[] { actuallist, expected, index };


            expected = new LinkedList(new int[] { 1, 2, 3, 4, 6 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 4;

            yield return new object[] { actuallist, expected, index };
        }
    }
}
