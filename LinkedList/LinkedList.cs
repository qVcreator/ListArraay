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
    }
}