using NUnit.Framework;
using ListArray.Tests.ListArrayTestSources;

namespace ListArray.Test
{
    public class ListArrayTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(ListArray actuallist, ListArray expected, int value)
        {
            actuallist.AddLast(value);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(ListArray actuallist, ListArray expected, int value)
        {
            actuallist.AddFirst(value);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(ListArray actuallist, ListArray expected, int value, int index)
        {
            actuallist.AddByIndex(index, value);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTestt(ListArray actuallist, ListArray expected)
        {
            actuallist.DeleteLast();
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ListArray actuallist, ListArray expected)
        {
            actuallist.DeleteFirst();
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(ListArray actuallist, ListArray expected, int index)
        {
            actuallist.DeleteByIndex(index);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(DeleteRangeOfLastTestSource))]
        public void DeleteRangeOfLastTest(ListArray actuallist, ListArray expected, int range)
        {
            actuallist.DeleteRangeOfLast(range);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(DeleteRangeOfFirstTestSource))]
        public void DeleteRangeOfFirstTest(ListArray actuallist, ListArray expected, int range)
        {
            actuallist.DeleteRangeOfFirst(range);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(DeleteRangeByIndexTestSourcce))]
        public void DeleteRangeByIndexTest(ListArray actuallist, ListArray expected, int range, int index)
        {
            actuallist.DeleteRangeByIndex(index,range);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(FindIndexByFirstElementTestSource))]
        public void FindIndexByFirstElementTest(ListArray list, int expected, int val)
        {
            int actual = list.FindIndexByFirstElement(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeElementByindexTestSource))]
        public void ChangeElementByindexTest(int index, int value, ListArray actualList, ListArray expected)
        {
            actualList.ChangeElementByindex(index, value);
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ListArray actualList, ListArray expected)
        {
            actualList.Reverse();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindMax();
            Assert.AreEqual(expected, actual);
        }


        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource ))]
        public void FindIndexOfMaxTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }


        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }


        [TestCaseSource(typeof(SortLessBiggerTestSource))]
        public void SortLessBiggerTest(ListArray actualList, ListArray expected)
        {
            actualList.SortLessBigger();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(SortBiggerLessTestSource))]
        public void SortBiggerLessTest(ListArray actualList, ListArray expected)
        {
            actualList.SortBiggerLess();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(DeleteFirstFoundTestSource))]
        public void DeleteFirstFoundTest(int value, ListArray actualList, ListArray expected, int actualIndex)
        {
            int expectedIndex = actualList.DeleteFirstFound(value);
            Assert.AreEqual(expected, actualList);
            Assert.AreEqual(expectedIndex, actualIndex);
        }


        [TestCaseSource(typeof(DeleteAllFoundElementsTesSource))]
        public void DeleteAllFoundElementsTest(int value, ListArray actualList, ListArray expected, int actualNumber)
        {
            int expectedNumber = actualList.DeleteAllFoundElements(value);
            Assert.AreEqual(expected, actualList);
            Assert.AreEqual(expectedNumber, actualNumber);
        }


        [TestCaseSource(typeof(AppendListTestSource))]
        public void AppendListTest(ListArray list, ListArray actualList, ListArray expected)
        {
            actualList.AppendList(list);
            Assert.AreEqual(expected, actualList);
            
        }

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(ListArray list, ListArray actualList, ListArray expected)
        {
            actualList.AddListToBegin(list);
            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index, ListArray list, ListArray actualList, ListArray expected)
        {
            actualList.AddListByIndex(index, list);
            Assert.AreEqual(expected, actualList);

        }
    }
}