using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests.LinkedListTestSources
{
    internal class DeleteFirstFoundTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 4, 5 });
            int index = 2;
            yield return new object[] { value, list, expectedList, index };


            value = 1;
            list = new LinkedList(new int[] { 1, 22, 33, 44, 55 });
            expectedList = new LinkedList(new int[] { 22,33,44,55 });
            index = 0;
            yield return new object[] { value, list, expectedList, index };

            value = 55;
            list = new LinkedList(new int[] { 1, 22, 33, 44, 55 });
            expectedList = new LinkedList(new int[] { 1, 22, 33, 44 });
            index = 4;
            yield return new object[] { value, list, expectedList, index };
        }
    }
}
