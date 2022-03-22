using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray expected = new ListArray(new int[] { 6, 5, 4, 3, 2, 1 });
            ListArray actuallist = new ListArray(new int[] { 6, 5, 4, 3, 2, 1 });
            ListArray addedList = new ListArray(new int[] { });
            int index = 3;

            yield return new object[] { index, addedList, actuallist, expected };


            expected = new ListArray(new int[] { 1, 2, 3, -77, -2, 0, -400 });
            actuallist = new ListArray(new int[] { -77, -2, 0, -400 });
            addedList = new ListArray(new int[] { 1, 2, 3 });
            index = 0;

            yield return new object[] { index, addedList, actuallist, expected };


            expected = new ListArray(new int[] { -77, -2, 0, 1, 2, 3, - 400 });
            actuallist = new ListArray(new int[] { -77, -2, 0, -400 });
            addedList = new ListArray(new int[] { 1, 2, 3 });
            index = 3;

            yield return new object[] { index, addedList, actuallist, expected };


            expected = new ListArray(new int[] {  77, 2, -7, -8, 1, 200, 0, 40, 0, 540 });
            actuallist = new ListArray(new int[] { 77, 2, 40, 0, 540 });
            addedList = new ListArray(new int[] { -7, -8, 1, 200, 0 });
            index = 2;

            yield return new object[] { index, addedList, actuallist, expected };
        }
    }
}
