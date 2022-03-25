using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class DeleteAllFoundElementsTesSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };


            value = 11;
            list = new LinkedList(new int[] { 1, 22, 33, 44, 55 });
            expectedList = new LinkedList(new int[] { 1,22, 33, 44, 55 });
            expectedNumber = 0;
            yield return new object[] { value, list, expectedList, expectedNumber };

            value = 55;
            list = new LinkedList(new int[] { 1, 22, 33, 55, 55 });
            expectedList = new LinkedList(new int[] { 1, 22, 33 });
            expectedNumber = 2;
            yield return new object[] { value, list, expectedList, expectedNumber };
        }
    }
}
