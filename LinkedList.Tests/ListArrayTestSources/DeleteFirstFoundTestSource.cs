using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArray.Tests.ListArrayTestSources
{
    internal class DeleteFirstFoundTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 4, 5 });
            int index = 2;
            yield return new object[] { value, list, expectedList, index };


            value = 1;
            list = new ListArray(new int[] { 1, 22, 33, 44, 55 });
            expectedList = new ListArray(new int[] { 22,33,44,55 });
            index = 0;
            yield return new object[] { value, list, expectedList, index };

            value = 55;
            list = new ListArray(new int[] { 1, 22, 33, 44, 55 });
            expectedList = new ListArray(new int[] { 1, 22, 33, 44 });
            index = 4;
            yield return new object[] { value, list, expectedList, index };
        }
    }
}
