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
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
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
            Node preLastNode = GetNode(Length-2);
            preLastNode.Next = null;
            _tail = preLastNode;
        }

        public void DeleteFirst()
        {
            _root.Next = GetNode(2);
        }

        public void DeleteByIndex(int index)
        {
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
            Node lastStayNode = GetNode(Length - 1 - range);
            lastStayNode.Next = null;
            _tail = lastStayNode;
        }

        public void DeleteRangeOfFirst(int range)
        {
            Node lastStayNode = GetNode(range);
            _root = lastStayNode;
        }

        public void DeleteRangeByIndex(int index, int range)
        {
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

        private static void SwapNodesValue(ref Node a, ref Node b)
        {
            Node swap = new Node(a.Value);
            a.Value = b.Value;
            b.Value = swap.Value;
        }
    }
}