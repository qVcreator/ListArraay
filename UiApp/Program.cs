using LinkedList;

LinkedList.LinkedList list = new LinkedList.LinkedList();

for (int i = 0; i < 10; i++)
{
    list.AddLast(i);
}

Console.WriteLine("go");
Console.WriteLine(list.ToString());
list.ChangeElementByindex(9,77);
Console.WriteLine(list.ToString());
Console.WriteLine("end");





























//using ListArray;



//int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
//int[] arr2 = new int[6] { 4, 2, 3, 4, 5, 4 };
//int[] arr3 = new int[3] { 1, 2, 3 };

//ListArray.ListArray list = new ListArray.ListArray(arr);
//ListArray.ListArray list2 = new ListArray.ListArray(arr2);
//ListArray.ListArray list3 = new ListArray.ListArray(arr3);

////Console.WriteLine("1-2-3");
////list.Show();
////list.AddByIndex(3, 777);
////list.AddLast(222);
////list.AddFirst(111);
////list.Show();
////Console.WriteLine("4-5-6");
////list.Show();
////list.DeleteByIndex(4);
////list.DeleteLast();
////list.DeleteFirst();
////list.Show();
////Console.WriteLine("7-8-9");
//Console.WriteLine(list.ToString());
//list.DeleteRangeOfFirst(2);
//Console.WriteLine(list.ToString());
////list.DeleteRangeByIndex(2, 3);
////list.DeleteRangeOfLast(2);
////list.Show();
////Console.WriteLine("10-11");
////Console.WriteLine(list.Length);
////int len = list.Length;
////int val = list.GetValue(0);
////Console.WriteLine("12-13");
////int index = list.FindIndexByFirstElement(3);
////Console.WriteLine(list.GetValue(index));
////list.ChangeElementByindex(index, 77);
////Console.WriteLine(list.GetValue(index));
////list.Show();
////Console.WriteLine("14");
////list.Show();
////list.Reverse();
////list.Show();
////Console.WriteLine("15-16-17-18");
////list.Show();
////Console.WriteLine(list.FindMax());
////Console.WriteLine(list.FindMin());
////Console.WriteLine(list.FindIndexOfMax());
////Console.WriteLine(list.FindIndexOfMin());
////Console.WriteLine("19-20");
////list.Show();
////list.SortBiggerLess();
////list.Show();
////list.SortLessBigger();
////list.Show();
////Console.WriteLine("21");
////list.Show();
////Console.WriteLine(list.DeleteFirstFound(3));
////list.Show();
////Console.WriteLine("22");
////list2.Show();
////Console.WriteLine(list2.DeleteAllFoundElements(4));
////list2.Show();
////Console.WriteLine("25");
////Console.Write("list 1: ");
////list.Show();
////Console.Write("list 2: ");
////list3.Show();
////list.AppendList(list3);
////Console.Write("united list 1 with list 2: ");
////list.Show();
////Console.WriteLine("26");
////Console.Write("list 1: ");
////list.Show();
////Console.Write("list 2: ");
////list3.Show();
////list.AddListToBegin(list3);
////Console.Write("united list 1 with list 2: ");
////list.Show();
////Console.WriteLine("27");
////Console.Write("list 1: ");
////list.Show();
////Console.Write("list 2: ");
////list3.Show();
////list.AddListByIndex(2,list3);
////Console.Write("united list 1 with list 2: ");
////list.Show();