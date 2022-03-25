using NUnit.Framework;
using LinkedList.Tests.LinkedListTestSources;
using LinkedList.Tests.LinkedListNegativeTestSources;
using System;

namespace LinkedList.Test
{
    public class ListArrayTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(LinkedList actuallist, LinkedList expected, int value)
        {
            actuallist.AddLast(value);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(LinkedList actuallist, LinkedList expected, int value)
        {
            actuallist.AddFirst(value);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(LinkedList actuallist, LinkedList expected, int value, int index)
        {
            actuallist.AddByIndex(index, value);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexOutOfLength_ShouldThrowException(LinkedList actuallist, int value, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(LinkedList actuallist, LinkedList expected)
        {
            actuallist.DeleteLast();
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastTest_WhenLengthOfListIsEquaalZero_ShouldThrowException(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(LinkedList actuallist, LinkedList expected)
        {
            actuallist.DeleteFirst();
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteFirstNegativeTestSource))]
        public void DeleteFirstTest_WhenLengthOfListIsEquaalZero_ShouldThrowException(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteFirst());
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(LinkedList actuallist, LinkedList expected, int index)
        {
            actuallist.DeleteByIndex(index);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenLengthOfListIsEquaalZero_ShouldThrowExceptionNegativeTestSource))]
        public void DeleteByIndexTest_WhenLengthOfListIsEquaalZero_ShouldThrowException(int index, LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenIndexOutOfLength_ShouldThrowExceptionNegativeTestSource))]
        public void DeleteByIndexTest_WhenIndexOutOfLength_ShouldThrowException(int index, LinkedList actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteRangeOfLastTestSource))]
        public void DeleteRangeOfLastTest(LinkedList actuallist, LinkedList expected, int range)
        {
            actuallist.DeleteRangeOfLast(range);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteRangeOfLastNegativeTestSource_WhenRnageGreaterThanLength))]
        public void DeleteRangeOfLastTest_WhenIndexOutOfLength_ShouldThrowException(int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteRangeOfLast(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeOfLastNegativeTestSource_WhenRnageLessThanZero))]
        public void DeleteRangeOfLastTest_WhenRnageLessThanZero_ShouldThrowException(int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteRangeOfLast(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeOfFirstTestSource))]
        public void DeleteRangeOfFirstTest(LinkedList actuallist, LinkedList expected, int range)
        {
            actuallist.DeleteRangeOfFirst(range);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteRangeOfFirstNegativeTestSource_WhenRnageGreaterThanLength))]
        public void DeleteRangeOfFirstTest_WhenIndexOutOfLength_ShouldThrowException(int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteRangeOfFirst(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeOfFirstNegativeTestSource_WhenRnageLessThanZero))]
        public void DeleteRangeOfFirstTest_WhenRangeLessThanZero_ShouldThrowException(int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteRangeOfFirst(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeByIndexTestSourcce))]
        public void DeleteRangeByIndexTest(LinkedList actuallist, LinkedList expected, int range, int index)
        {
            actuallist.DeleteRangeByIndex(index, range);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteRangeByIndexNegativeTestSource_WhenIndexOutOfRange))]
        public void DeleteRangeByIndexTest_WhenIndexOutOfRange_ShouldThrowException(int index, int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteRangeByIndex(index, rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeByIndexNegativeTestSource_WhenRangeGreaterThanLength))]
        public void DeleteRangeByIndexTest_WhenRangeGreaterThanLength_ShouldThrowException(int index, int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => actuallist.DeleteRangeByIndex(index, rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeByIndexNegativeTestSource_WhenRangeLessThanZero))]
        public void DeleteRangeByIndexTest_WhenRangeLessThanZero_ShouldThrowException(int index, int rangeLength, LinkedList actuallist)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteRangeByIndex(index, rangeLength));
        }

        [TestCaseSource(typeof(FindIndexByFirstElementTestSource))]
        public void FindIndexByFirstElementTest(LinkedList list, int expected, int val)
        {
            int actual = list.FindIndexByFirstElement(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeElementByindexTestSource))]
        public void ChangeElementByindexTest(int index, int value, LinkedList actualList, LinkedList expected)
        {
            actualList.ChangeElementByindex(index, value);
            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(ChangeElementByindexNegativeTestSource_WhenLengthIsEqualsZero))]
        public void ChangeElementByindexTest_WhenLengthIsEqualsZero_ShouldThrowException(int index, int value, LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.ChangeElementByindex(index, value));
        }

        [TestCaseSource(typeof(ChangeElementByindexNegativeTestSource_WhenIndexOutOfLength))]
        public void ChangeElementByindexTest_WhenIndexOutOfLength_ShouldThrowException(int index, int value, LinkedList actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.ChangeElementByindex(index, value));
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkedList actualList, LinkedList expected)
        {
            actualList.Reverse();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(LinkedList actualList, int expected)
        {
            int actual = actualList.FindMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMinNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindMaxTest_WhenLengthIsEqualsZero(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindMax());
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(LinkedList actualList, int expected)
        {
            int actual = actualList.FindMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMaxNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindMinTest_WhenLengthIsEqualsZero(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindMin());
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(LinkedList actualList, int expected)
        {
            int actual = actualList.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindIndexOfMaxTest_WhenLengthIsEqualsZero(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindIndexOfMax());
        }

        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(LinkedList actualList, int expected)
        {
            int actual = actualList.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindIndexOfMinTest_WhenLengthIsEqualsZero(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindIndexOfMin());
        }


        [TestCaseSource(typeof(SortLessBiggerTestSource))]
        public void SortLessBiggerTest(LinkedList actualList, LinkedList expected)
        {
            actualList.SortLessBigger();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(SortBiggerLessTestSource))]
        public void SortBiggerLessTest(LinkedList actualList, LinkedList expected)
        {
            actualList.SortBiggerLess();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(DeleteFirstFoundTestSource))]
        public void DeleteFirstFoundTest(int value, LinkedList actualList, LinkedList expected, int actualIndex)
        {
            int expectedIndex = actualList.DeleteFirstFound(value);
            Assert.AreEqual(expected, actualList);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(DeleteFirstFoundNegativeTest_WhenLengthIsEqualsZero))]
        public void DeleteFirstFoundTest_WhenLengthIsEqualsZero(int value, LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteFirstFound(value));
        }

        [TestCaseSource(typeof(DeleteAllFoundElementsTesSource))]
        public void DeleteAllFoundElementsTest(int value, LinkedList actualList, LinkedList expected, int actualNumber)
        {
            int expectedNumber = actualList.DeleteAllFoundElements(value);
            Assert.AreEqual(expected, actualList);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestCaseSource(typeof(DeleteAllFoundElementsNegativeTest_WhenLengthIsEqualsZero))]
        public void DeleteAllFoundElementsTest_WhenLengthIsEqualsZero(int value, LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteFirstFound(value));
        }

        [TestCaseSource(typeof(AppendListTestSource))]
        public void AppendListTest(LinkedList list, LinkedList actualList, LinkedList expected)
        {
            actualList.AppendList(list);
            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeTestSource_WhenListIsNull))]
        public void AppendListTest_WhenListIsNull(LinkedList list, LinkedList actuallist)
        {
            Assert.Throws<ArgumentNullException>(() => actuallist.AppendList(list));
        }


        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(LinkedList list, LinkedList actualList, LinkedList expected)
        {
            actualList.AddListToBegin(list);
            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeTestSource_WhenListIsNull))]
        public void AddListToBeginTest_WhenListIsNull(LinkedList list, LinkedList actuallist)
        {
            Assert.Throws<ArgumentNullException>(() => actuallist.AddListToBegin(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index, LinkedList list, LinkedList actualList, LinkedList expected)
        {
            actualList.AddListByIndex(index, list);
            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(AddListByIndexNegativeTestSource_WhenIndexOutOfLength))]
        public void AddListByIndexTest_WhenListIsNull(int index, LinkedList list, LinkedList actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.AddListByIndex(index, list));
        }
    }
}