using ListArray;


int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };

ListArray.ListArray list = new ListArray.ListArray(arr);

Console.WriteLine("1-2-3");
list.Show();
list.AddByIndex(3, 777);
list.AddLast(222);
list.AddFirst(111);
list.Show();