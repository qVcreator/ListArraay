using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.LinkedListNegativeTestSources
{
    internal class AddListByIndexNegativeTestSource_WhenListIsNull : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList addedList = null;
            int index = 2;

            yield return new object[] { index, addedList, actuallist };
        }
    }

    internal class AddListByIndexNegativeTestSource_WhenIndexOutOfLength : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList addedList = new LinkedList(new int[] { 1, 2 });
            int index = -1;

            yield return new object[] { index, addedList, actuallist };

            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            addedList = new LinkedList(new int[] { 1, 2 });
            index = 6;

            yield return new object[] { index, addedList, actuallist };

            actuallist = new LinkedList(new int[] { 1 });
            addedList = new LinkedList(new int[] { 1, 2 });
            index = 6;

            yield return new object[] { index, addedList, actuallist };

            actuallist = new LinkedList(new int[] { 1 });
            addedList = new LinkedList(new int[] { 1, 2 });
            index = -1;

            yield return new object[] { index, addedList, actuallist };


            actuallist = new LinkedList(new int[] { });
            addedList = new LinkedList(new int[] { 1, 2 });
            index = -1;

            yield return new object[] { index, addedList, actuallist };
        }
    }

    internal class AddListByIndexNegativeTestSource_WhenListIsEmpty : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1 });
            LinkedList actuallist = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1 });
            LinkedList addedList = new LinkedList();
            int index = 3;

            yield return new object[] { index, addedList, actuallist};
        }
    }
}