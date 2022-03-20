using NUnit.Framework;

namespace ListArray.Test
{
    public class ListArrayTests
    {
        [TestCase(ListEnums.AddLast)]
        public void AddLastTest(ListEnums expectedType)
        {
            ListArray actual = ListArrayMock.GetMock(ListEnums.baseList);
            ListArray expected = ListArrayMock.GetMock(ListEnums.AddLast);
            actual.AddLast(7);
            for (int i = 0; i < expected.Length; i++)
            {
            Assert.AreEqual(expected.GetValue(i), actual.GetValue(i));
            }
        }
    }
}