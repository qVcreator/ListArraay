using NUnit.Framework;
using System.Collections;
using ListArray.Tests.ListArrayTestSources;

namespace ListArray.Test
{
    public class ListArrayTests
    {
        [TestCaseSource(typeof(DeleteLastTestSource))]
        
        public void AddLastTest(ListArray actuallist, ListArray expected, int num)
        {
            actuallist.AddLast(num);
            Assert.AreEqual(expected, actuallist);
        }
    }
}