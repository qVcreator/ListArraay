using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5});
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { });
            actuallist = new LinkedList(new int[] { 7 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { 7});
            actuallist = new LinkedList(new int[] { 7,2 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { 1, 2, 3, 4 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, -7 });

            yield return new object[] { actuallist, expected };
        }
    }
}
