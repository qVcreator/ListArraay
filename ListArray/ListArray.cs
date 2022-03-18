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
            if (Length+1 >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            MoveRightSide();

            _array[0] = value;
        }

        private void MoveRightSide()
        {
            int[] newArr = new int[Length+1];
            for (int i=0; i < Length; i++)
            {
                newArr[i+1] = _array[i];
            }
            _array = newArr;
        }
        private void IncreaseLengthOfArray()
        {
            int newLength = (int)(_array.Length * 1.5);
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