namespace Queue
{
    public class ArrayQueue<T>
    {
        private int size;
        private T[] array;
        private int index;

        public int Count { get; private set; }

        public ArrayQueue()
        {
            this.size = 4;
            this.array = new T[this.size];
        }

        public void Enqueue(T item)
        {
            if (Count == size)
            {
                IncreaseSize();
            }

            array[index++] = item;
            Count++;
        }

        public T Dequeue()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("The Queue is empty!");
            }

            var itemToRemove = this.array[0];
            array[0] = default!;
            ShiftToTheLeft(0);
            Count--;

            return itemToRemove;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Queue is empty!");
            }

            return array[0];
        }

        private void IncreaseSize()
        {
            T[] tempArray = new T[this.size * 2];
            size = size * 2;
            array.CopyTo(tempArray, 0);
            array = tempArray;
        }

        private void Shrink()
        {
            T[] copy = new T[array.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = array[i];
            }
            array = copy;
        }

        private void SwitchElements()
        {
            array[0] = default!;

            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }

            array[array.Length - 1] = default!;
        }

        private void ShiftToTheLeft(int index)
        {
            for (int i = index; i < Count; i++)
            {
                array[i] = array[i + 1];
            }
        }

        public bool IsEmpty() => Count == 0;
    }

}
