namespace LinkedList
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                crnt.Value = value;
            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        public LinkedList()
        {
            _root = null;

            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;

                _tail = null;
            }
            else
            {
                _root = new Node(array[0]);
                Node crnt = _root;
                _tail = crnt;
                for (int i = 1; i < array.Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                    _tail = crnt;
                }
            }

        }

        public void AddLast(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        public void AddFirst(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                if (index == 0)
                {
                    AddFirst(value);
                }
                else
                {
                    Node previousNode = GetNode(index - 1);
                    Node nextNode = previousNode.Next;
                    Node newNode = new Node(value);
                    previousNode.Next = newNode;
                    newNode.Next = nextNode;
                }
            }
        }

        public void DeleteLast()
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            int tmp = Length;
            if (tmp < 2)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node preLastNode = GetNode(Length - 2);
                preLastNode.Next = null;
                _tail = preLastNode;
            }
        }

        public void DeleteFirst()
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            _root = _root.Next;
        }

        public void DeleteByIndex(int index)
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node prevNode = GetNode(index - 1);
                Node nextNode = prevNode.Next.Next;
                prevNode.Next = nextNode;
                if (index == Length)
                {
                    _tail = prevNode;
                }
            }
            
        }

        public void DeleteRangeOfLast(int range)
        {
            if(range < 0 || range > Length)
            {
                throw new ArgumentException("range");
            }
            int len = Length;
            if (len == range)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node lastStayNode = GetNode(len - 1 - range);
                lastStayNode.Next = null;
                _tail = lastStayNode;
            }
            
        }

        public void DeleteRangeOfFirst(int range)
        {
            if (range < 0 || range > Length)
            {
                throw new ArgumentException("range");
            }
            Node lastStayNode = GetNode(range);
            _root = lastStayNode;
        }

        public void DeleteRangeByIndex(int index, int range)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if ((index + range) > Length)
            {
                throw new ArgumentOutOfRangeException("range");
            }
            if (range < 0 || range > Length)
            {
                throw new ArgumentException("range");
            }

            Node stop = GetNode(index - 1);
            Node keep = GetNode(index + range);

            if (index + range == Length)
            {
                _tail = stop;
            }

            if (index > 0)
            {
                stop.Next = keep;
            }
            else
            {
                _root  = keep;
            }
        }

        public int FindIndexByFirstElement(int value)
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }
            int index = -1;
            Node crnt = _root;
            for (int i = 0;crnt != null; i++)
            {
                if (crnt.Value == value) 
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        public void ChangeElementByindex(int index, int value)
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to change");
            }
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            Node changeableNode = GetNode(index);
            changeableNode.Value = value;

        }

        public void Reverse()
        {
            if (_tail is null)
            {
                throw new Exception();
            }
            Node crnt = _root;
            Node next;
            while (crnt.Next != null)
            {
                next = crnt.Next;
                crnt.Next = next.Next;
                next.Next = _root;
                _root = next;
            }
        }

        public int FindMax()
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }
            Node crnt = _root;
            int max = crnt.Value;
            while (crnt != null)
            {
                if(crnt.Value > max)
                {
                    max = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return max;
        }

        public int FindMin()
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }
            Node crnt = _root;
            int min = crnt.Value;
            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return min;
        }

        public int FindIndexOfMax()
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }

            Node crnt = _root;
            int max = crnt.Value;
            int i = 0;
            int index = 0;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    index = i;
                }
                i++;
                crnt = crnt.Next;
            }
            return index;
        }

        public int FindIndexOfMin()
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }

            Node crnt = _root;
            int min = crnt.Value;
            int i = 0;
            int index = 0;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    index = i;
                }
                i++;
                crnt = crnt.Next;
            }
            return index;
        }

        public void SortLessBigger()
        {            
            for (int i=0; i<Length-1; i++)
            {
                
                Node crnt = _root;
                Node next = crnt.Next;
                Node previous = _root;

                int j = 0;
                while (next != null)
                {
                    if (crnt == _root && crnt.Value > next.Value)
                    {
                        crnt.Next = next.Next;
                        _root = next;
                        next.Next = crnt;
                        previous = next;
                        j++;
                    }
                    else if (crnt.Value > next.Value) 
                    {
                        crnt.Next = next.Next;
                        previous.Next = next;
                        next.Next = crnt;
                        previous = next;
                        j++;
                    }
                    else
                    {
                        crnt = crnt.Next;
                        j++;
                        if (j > 1)
                        {
                            previous = previous.Next;
                        }
                        
                    }
                    next = crnt.Next;
                }
            }
        }

        public void SortBiggerLess()
        {
            for (int i = 0; i < Length - 1; i++)
            {

                Node crnt = _root;
                Node next = crnt.Next;
                Node previous = _root;

                int j = 0;
                while (next != null)
                {
                    if (crnt == _root && crnt.Value < next.Value)
                    {
                        crnt.Next = next.Next;
                        _root = next;
                        next.Next = crnt;
                        previous = next;
                        j++;
                    }
                    else if (crnt.Value < next.Value)
                    {
                        crnt.Next = next.Next;
                        previous.Next = next;
                        next.Next = crnt;
                        previous = next;
                        j++;
                    }
                    else
                    {
                        crnt = crnt.Next;
                        j++;
                        if (j > 1)
                        {
                            previous = previous.Next;
                        }

                    }
                    next = crnt.Next;
                }
            }
        }

        public int DeleteFirstFound(int value)
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }
            Node crnt = _root;
            int index=0;
            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    if (index == 0)
                    {
                        _root = crnt.Next;
                        break;
                    }
                    else
                    {
                        Node previous = GetNode(index - 1);
                        previous.Next = crnt.Next;
                        break;
                    }
                }
                index++;
                crnt = crnt.Next;
            }

            return index;
        }

        public int DeleteAllFoundElements(int value)
        {
            if (_tail is null)
            {
                throw new Exception("You have nothing to find");
            }

            Node crnt = _root;
            int index=0;
            int count = 0;

            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    if (index == 0)
                    {
                        _root = crnt.Next;
                        count++;
                        index--;
                    }
                    else
                    {
                        Node previous = GetNode(index - 1);
                        previous.Next = crnt.Next;
                        count++;
                        index--;
                    }
                }
                index++;
                crnt = crnt.Next;
            }

            return count;
        }

        public void AppendList(LinkedList list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            _tail.Next = list._root;
            _tail = list._tail;
        }

        public void AddListToBegin(LinkedList list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (list._tail is null)
            {
                throw new ArgumentException("list");
            }

            LinkedList tmp = CreateTmp(list);
            Node crnt = tmp._tail;
            Node newRoot = tmp._root;
            crnt.Next = _root;
            _root = newRoot;
        }

        public void AddListByIndex(int index, LinkedList list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            if (list._tail is null)
            {
                throw new ArgumentException("list");
            }
            if (index > 0)
            {
                LinkedList tmp = CreateTmp(list);
                Node stop = GetNode(index - 1);
                Node keep = stop.Next;
                stop.Next = tmp._root;
                tmp._tail.Next = keep;
            }
            else
            {
                AddListToBegin(list);
            }

        }

        public override string ToString()
        {
            string str = "[ ";
            Node crnt = _root;
            while (crnt != null)
            {
                str += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            str += "]";

            return str;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }
            Node crnt = _root;
            Node crnt2 = list._root;
            while(crnt != null)
            {
                if (crnt.Value != crnt2.Value)
                {
                    return false;
                }
                crnt = crnt.Next;
                crnt2 = crnt2.Next;
            }

            return true;
        }

        private Node GetNode(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }
        private LinkedList CreateTmp(LinkedList list)
        {
            Node crnt = list._root;
            LinkedList tmp = new LinkedList();
            while (crnt != null)
            {
                tmp.AddLast(crnt.Value);
                crnt = crnt.Next;
            }
            return tmp;
        }

        private static void SwapNodesValue(ref Node a, ref Node b)
        {
            Node swap = new Node(a.Value);
            a.Value = b.Value;
            b.Value = swap.Value;
        }
    }
}