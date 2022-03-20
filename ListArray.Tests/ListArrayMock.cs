using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListArray;

namespace ListArray.Test
{
    public static class ListArrayMock
    {
        public static ListArray GetMock(ListEnums type)
        {
            switch (type)
            {
                case ListEnums.baseList:
                    return new ListArray(new int[6] { 1, 2, 3, 4, 5, 6 });
                    break;
                case ListEnums.baseList2:
                    return new ListArray(new int[6] { 4,2,3,4,5,4 });
                    break;
                case ListEnums.baseList3:
                    return new ListArray(new int[3] { 1, 2, 3});
                    break;
                case ListEnums.AddLast:
                    return new ListArray(new int[7] { 1, 2, 3, 4, 5, 6, 7 });
                    break;
                case ListEnums.AddLast2:
                    return new ListArray(new int[7] { 1, 2, 3, 4, 5, 6, -2 });
                    break;
                case ListEnums.AddLast3:
                    return new ListArray(new int[7] { 1, 2, 3, 4, 5, 6, 0 });
                    break;
                case ListEnums.AddFirst:
                    return new ListArray(new int[7] { 7, 1, 2, 3, 4, 5, 6 });
                    break;
                case ListEnums.AddFirst2:
                    return new ListArray(new int[7] { -2, 1, 2, 3, 4, 5, 6 });
                    break;
                case ListEnums.AddFirst3:
                    return new ListArray(new int[7] { 0, 1, 2, 3, 4, 5, 6 });
                    break;
                case ListEnums.AddByIndex:
                    return new ListArray(new int[7] { 1, 2, 7, 3, 4, 5, 6 });
                    break;
                case ListEnums.DeleteLast:
                    return new ListArray(new int[5] { 1, 2, 3, 4, 5});
                    break;
                case ListEnums.DeleteFirst:
                    return new ListArray(new int[5] { 2, 3, 4, 5, 6 });
                    break;
                case ListEnums.DeleteByIndex:
                    return new ListArray(new int[5] { 1, 2, 4, 5, 6 });
                    break;
                case ListEnums.DeleteRangeOfLast:
                    return new ListArray(new int[3] { 1, 2, 3 });
                    break;
                case ListEnums.DeleteRangeOfFirst:
                    return new ListArray(new int[3] { 4, 5, 6 });
                    break;
                case ListEnums.DeleteRangeByIndex:
                    return new ListArray(new int[3] { 1, 2, 6 });
                    break;
                case ListEnums.ChangeElementByindex:
                    return new ListArray(new int[6] { 1, 2, 7, 4, 5, 6 });
                    break;
                case ListEnums.Reverse:
                    return new ListArray(new int[6] { 6,5,4,3,2,1 });
                    break;
                case ListEnums.SortLessBigger:
                    return new ListArray(new int[6] { 2,3,4,4,4,5});
                    break;
                case ListEnums.SortBiggerLess:
                    return new ListArray(new int[6] { 5,4,4,4,3,2 });
                    break;
                case ListEnums.DeleteFirstFound:
                    return new ListArray(new int[5] { 1, 2, 3, 5, 6 });
                    break;
                case ListEnums.DeleteAllFoundElements:
                    return new ListArray(new int[3] { 2,3,5});
                    break;
                case ListEnums.AppendList:
                    return new ListArray(new int[9] { 1, 2, 3, 4, 5, 6, 1, 2, 3 });
                    break;
                case ListEnums.AddListToBegin:
                    return new ListArray(new int[9] {1,2,3, 1, 2, 3, 4, 5, 6 });
                    break;
                case ListEnums.AddListByIndex:
                    return new ListArray(new int[9] { 1, 2, 3,1,2,3, 4, 5, 6 });
                    break;
                default:
                    throw new ArgumentException("type");

            }
        }   
    }
}
