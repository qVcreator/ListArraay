using NUnit.Framework;

namespace ListArray.Test
{
    public class ListArrayTests
    {
        [TestCase(ListEnums.AddLast, 7)]
        [TestCase(ListEnums.AddLast2, -2)]
        [TestCase(ListEnums.AddLast3, 0)]
        public void AddLastTest(ListEnums expectedType, int addNum)
        {
            ListArray actual = ListArrayMock.GetMock(ListEnums.baseList);
            ListArray expected = ListArrayMock.GetMock(expectedType);
            actual.AddLast(addNum);
            for (int i = 0; i < expected.Length; i++)
            {
            Assert.AreEqual(expected.GetValue(i), actual.GetValue(i));
            }
        }
    }
}