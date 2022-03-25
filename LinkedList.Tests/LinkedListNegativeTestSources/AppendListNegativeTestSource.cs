using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListArray.Tests.ListArrayNegativeTestSources
{
    internal class NegativeTestSource_WhenListIsNull : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray actuallist = new ListArray(new int[] {1,2,3,4,5 });
            ListArray addedList = null;

            yield return new object[] { addedList, actuallist };
        }
    }
}
