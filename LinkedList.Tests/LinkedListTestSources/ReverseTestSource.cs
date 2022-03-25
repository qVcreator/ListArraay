using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 6,5,4,3,2,1 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { -77});
            actuallist = new LinkedList(new int[] { -77 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { });
            actuallist = new LinkedList(new int[] { });

            yield return new object[] { actuallist, expected };
        }
    }
}
