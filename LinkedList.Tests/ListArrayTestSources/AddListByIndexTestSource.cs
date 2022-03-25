using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1 });
            LinkedList actuallist = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1 });
            LinkedList addedList = new LinkedList(new int[] { });
            int index = 3;

            yield return new object[] { index, addedList, actuallist, expected };


            expected = new LinkedList(new int[] { 1, 2, 3, -77, -2, 0, -400 });
            actuallist = new LinkedList(new int[] { -77, -2, 0, -400 });
            addedList = new LinkedList(new int[] { 1, 2, 3 });
            index = 0;

            yield return new object[] { index, addedList, actuallist, expected };


            expected = new LinkedList(new int[] { -77, -2, 0, 1, 2, 3, - 400 });
            actuallist = new LinkedList(new int[] { -77, -2, 0, -400 });
            addedList = new LinkedList(new int[] { 1, 2, 3 });
            index = 3;

            yield return new object[] { index, addedList, actuallist, expected };


            expected = new LinkedList(new int[] {  77, 2, -7, -8, 1, 200, 0, 40, 0, 540 });
            actuallist = new LinkedList(new int[] { 77, 2, 40, 0, 540 });
            addedList = new LinkedList(new int[] { -7, -8, 1, 200, 0 });
            index = 2;

            yield return new object[] { index, addedList, actuallist, expected };
        }
    }
}
