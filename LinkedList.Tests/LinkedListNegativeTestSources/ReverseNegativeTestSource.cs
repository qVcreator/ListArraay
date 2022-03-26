using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class ReverseNegativeTestSource_WhenListsIsEmpty : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { });
            LinkedList actuallist = new LinkedList(new int[] { });

            yield return new object[] { actuallist};
        }
    }
}
