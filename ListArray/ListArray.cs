namespace ListArray
{
    public class ListArray
    {
        public int Length { get;private set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        private int[] _array;

        public ListArray()
        {
            _array = new int[5];
            Length = 2;
        }

        public ListArray(int Length)
        {
            _array = new int[(int)(Length * 1.5)];
            this.Length = Length;
        }

        public ListArray(int[] array)
        {
            _array = array;
            Length = _array.Length;
        }

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
            Length++;
        }

        public void AddByIndex(int index, int value)
        {
            if (Length + 1 >= _array.Length)
            {
                IncreaseLengthOfArray();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            } 

            MoveRightSide(index);

            _array[index] = value;

            Length++;
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

        public void DeleteFirst()
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
            Length--;
        }

        public void DeleteByIndex(int index)
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            MoveLeftSideFromAnyPart(index);
            Length--;
        }

        public int GetValue(int index)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException("IndexOutOfRange");
            }

            return _array[index];
        }

        public void DeleteRangeOfLast(int rangeLength)
        {
            if (Length < rangeLength)
            {
                throw new IndexOutOfRangeException("rangeLength");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i = 0; i < rangeLength; i++)
            {
                DeleteLast();
            }
        }

        public void DeleteRangeOfFirst(int rangeLength)
        {
            if (Length < rangeLength)
            {
                throw new IndexOutOfRangeException("rangeLength");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            StepLeftOptimized(rangeLength);
        }

        public void DeleteRangeByIndex(int index, int rangeLength)
        {
            if (index < 0||index>_array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            if ((index+rangeLength) > Length)
            {
                throw new ArgumentOutOfRangeException("rangeLength");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            StepLeftOptimized(rangeLength,index);
        }

        public int FindIndexByFirstElement(int value)
        {
            if(Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            
            int index = FindVal(value);

            return index;
        }

        public void ChangeElementByindex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to change");
            }
            if (Length < index)
            {
                throw new IndexOutOfRangeException("Length have to be greater than index");
            }

            _array[index] = value;
        }

        public void Reverse()
        {
            int[] tmpArr = new int[Length];
            int j = 0;

            for (int i = Length - 1; i >= 0; i--)
            {
                tmpArr[j] = _array[i];
                j++;
            }

            _array = tmpArr;
        }

        public int FindMax()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int FindMin()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int FindIndexOfMax()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int maxIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > _array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public int FindIndexOfMin()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int minIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < _array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public void SortLessBigger()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = Length - 1; j > 0; j--)
                {
                    if (_array[j] < _array[j - 1])
                    {
                        SwapNums(ref _array[j], ref _array[j - 1]);
                    }
                }
            }
        }

        public void SortBiggerLess()
        {
            int[] tmpArr = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                int count = Length;
                for (int j = 0; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        count--;

                    }
                }
                tmpArr[count - 1] = _array[i];
            }

            _array = tmpArr;
        }

        public int DeleteFirstFound(int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to delete");
            }

            int index = -1;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    MoveLeftSideFromAnyPart(i);
                    break;
                }
            }

            Length--;

            return index;

        }

        public int DeleteAllFoundElements(int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to delete");
            }

            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }

        public void AppendList(ListArray list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            for (int i = 0; i < list.Length; i++)
            {
                AddLast(list.GetValue(i));
            }    
        }

        public void AddListToBegin(ListArray list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (Length + list.Length >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            AddList(list);
        }

        public void AddListByIndex(int index, ListArray list)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (Length + list.Length+index >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            AddList(list, index);
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < Length; i++)
            {
                str += $"{_array[i]} ";
            }

            return str;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is ListArray))
            {
                return false;
            }

            ListArray list = (ListArray)obj;

            if (list.Length != this.Length)
            {
                return false;
            }
            for (int i = 0; i < this.Length; i++)
            {
                if (list[i] != this[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void StepLeftOptimized(int rangeLength, int index=0)
        {
            int newLength = _array.Length - rangeLength;
            for (int i = index; i < newLength; i++)
            {
                _array[i] = _array[i + rangeLength];
            }
            Length -= rangeLength;
        }

        private void AddList(ListArray list, int index=0)
        {
            int[] tmpArr = new int[_array.Length+list.Length];

            for (int i = 0; i < index; i++)
            {
                tmpArr[i]=_array[i];
            }
            for (int i = list.Length+index; i < tmpArr.Length; i++)
            {
                tmpArr[i] = _array[i-list.Length];
            }
            for (int i = index; i < list.Length+index; i++)
            {
                tmpArr[i] = list.GetValue(i-index);
            }

            Length += list.Length;

            _array = tmpArr;
        }

        private void MoveRightSide(int index=0)
        {
            int[] newArr = new int[Length+1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArr[i+1] = _array[i];
            }
            _array = newArr;
        }

        private void MoveLeftSideFromAnyPart(int index = 0)
        {
            int[] newArr = new int[_array.Length-1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < _array.Length-1; i++)
            {
                newArr[i] = _array[i+1];
            }
            _array = newArr;
        }

        private void MoveLeftSide()
        {
            int[] newArr = new int[Length-1];
            for (int i = 0; i < Length-1; i++)
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

        private int FindVal(int value)
        {
            int neededIndex = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    neededIndex = i;
                    break;
                }
            }
            return neededIndex;
        }

        private static void SwapNums(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
    }
}