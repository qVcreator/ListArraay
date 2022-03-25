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
    }
}