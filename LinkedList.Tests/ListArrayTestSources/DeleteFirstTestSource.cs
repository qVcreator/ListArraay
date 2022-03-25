using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 2, 3, 4, 5, 6 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { });
            actuallist = new LinkedList(new int[] { 7 });

            yield return new object[] { actuallist, expected };


            expected = new LinkedList(new int[] { 1, 2, 3, 4 });
            actuallist = new LinkedList(new int[] { -7, 1, 2, 3, 4 });

            yield return new object[] { actuallist, expected };
        }
    }
}
