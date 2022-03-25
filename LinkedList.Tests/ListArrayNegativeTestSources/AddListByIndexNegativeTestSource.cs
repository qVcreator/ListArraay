using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayNegativeTestSources
{
    internal class AddListByIndexNegativeTestSource_WhenListIsNull : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray addedList = null;
            int index = 2;

            yield return new object[] { index, addedList, actuallist };
        }
    }

    internal class AddListByIndexNegativeTestSource_WhenIndexOutOfLength : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray addedList = new ListArray(new int[] { 1, 2});
            int index = -1;

            yield return new object[] { index, addedList, actuallist };

            actuallist = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            addedList = new ListArray(new int[] { 1, 2 });
            index = 6;

            yield return new object[] { index, addedList, actuallist };

            actuallist = new ListArray(new int[] { 1 });
            addedList = new ListArray(new int[] { 1, 2 });
            index = 6;

            yield return new object[] { index, addedList, actuallist };

            actuallist = new ListArray(new int[] { 1 });
            addedList = new ListArray(new int[] { 1, 2 });
            index = -1;

            yield return new object[] { index, addedList, actuallist };


            actuallist = new ListArray(new int[] { });
            addedList = new ListArray(new int[] { 1, 2 });
            index = -1;

            yield return new object[] { index, addedList, actuallist };
        }
    }
}
