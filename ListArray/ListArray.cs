namespace ListArray
{
    public class ListArray
    {
        public int Length { get;private set; }

        private int[] _array;

        public void AddLast(int value)
        {
            if(Length >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
        {
            if (Length + 1 >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            MoveRightSide();

            _array[0] = value;
        }

        public void AddByIndex(int num, int value)
        {
            if (Length + 1 >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            MoveRightSide(num);

            _array[num] = _array[value];
        }

        public void DeleteLast()
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }
            Length--;
        }

        public void DeletFirst()
        {
            if (_array.Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            MoveLeftSide();
        }

        public void DeleteByIndex(int num)
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            MoveLeftSideFromAnyPart(num);
        }

        public void DeleteRangeOfLast(int rangeLength)
        {
            if (Length < rangeLength)
            {
                throw new Exception("List have no so many elements you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i = 0; i < rangeLength; i++)
            {
                Length--;
            }
        }

        public void DeleteRangeOfFirst(int rangeLength)
        {
            if (Length < rangeLength)
            {
                throw new Exception("List have no so many elements you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i=0; i < rangeLength; i++)
            {
                MoveLeftSide();
            }
        }

        public void DeleteRangeByIndex(int index, int rangeLength)
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i=0; i<rangeLength, i++)
            {
                MoveLeftSideFromAnyPart(index);
            }
        }

        private void MoveRightSide(int index=0)
        {
            int[] newArr = new int[Length+1];
            for (int i = index; i < Length; i++)
            {
                newArr[i+1] = _array[i];
            }
            _array = newArr;
        }

        private void MoveLeftSideFromAnyPart(int index = 0)
        {
            Length--;
            int[] newArr = new int[Length];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArr[i] = _array[i+1];
            }
            _array = newArr;
        }

        private void MoveLeftSide()
        {
            Length--;
            int[] newArr = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                newArr[i] = _array[i + 1];
            }
            _array = newArr;
        }

        private void IncreaseLengthOfArray()
        {
            int newLength = (int)(_array.Length * 1.5);
            int[] newArr = new int[newLength];
            Copy(newArr);       
        }

        private void DecreaseLengthOfArray()
        {
            int newLength = _array.Length / 3;
            int[] newArr = new int[newLength];
            Copy(newArr);
        }

        private void Copy(int[] newArr)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArr[i] = _array[i];
            }
            _array = newArr;
        }
    }
}