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
            _root = new Node(array[0]);
            Node crnt = _root;
            for (int i = 1; i < array.Length; i++)
            {
                crnt.Next = new Node(array[i]);
                crnt = crnt.Next;
                if(i == array.Length - 1)
                {
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
                Node previousNode = GetNode(index - 1);
                Node nextNode = GetNode(index);
                Node newNode = new Node(value);
                previousNode.Next = newNode;
                newNode.Next = nextNode;
            }
        }

        public void DeleteLast()
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            Node preLastNode = GetNode(Length-2);
            preLastNode.Next = null;
            _tail = preLastNode;
        }

        public void DeleteFirst()
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            _root.Next = GetNode(2);
        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            Node prevNode = GetNode(index-1);
            Node nextNode = GetNode(index+1);
            prevNode.Next = nextNode;
            if (index == Length - 1)
            {
                _tail = prevNode;
            }
            
        }

        public void DeleteRangeOfLast(int range)
        {
            if(range < 0 || range > Length)
            {
                throw new ArgumentOutOfRangeException("range");
            }
            Node lastStayNode = GetNode(Length - 1 - range);
            lastStayNode.Next = null;
            _tail = lastStayNode;
        }

        public void DeleteRangeOfFirst(int range)
        {
            if (range < 0 || range > Length)
            {
                throw new ArgumentOutOfRangeException("range");
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
                throw new ArgumentOutOfRangeException("rangeLength");
            }
            if (range < 0 || range > Length)
            {
                throw new ArgumentOutOfRangeException("range");
            }
            Node stop = GetNode(index - 1);
            Node keep = GetNode(index + range);
            if (index > 0)
            {
                stop.Next = keep;
            }
            else
            {
                _root  = keep;
            }            
            
            if (index+range  == Length)
            {
                _tail=stop;
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
                while (next != null)
                {
                    if (crnt.Value > next.Value)
                    {
                        SwapNodesValue(ref crnt, ref next);
                    }
                    crnt = crnt.Next;
                    next = next.Next;
                }
            }
        }

        public void SortBiggerLess()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                Node crnt = _root;
                Node next = crnt.Next;
                while (next != null)
                {
                    if (crnt.Value < next.Value)
                    {
                        SwapNodesValue(ref crnt, ref next);
                    }
                    crnt = crnt.Next;
                    next = next.Next;
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
            if (index > 0)
            {
                LinkedList tmp = CreateTmp(list);
                Node stop = GetNode(index - 1);
                Node keep = GetNode(index);
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