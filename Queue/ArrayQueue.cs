using System;

namespace DataStructures.Queue
{
    public class ArrayQueue
    {
        private int[] _queue;
        private int _front;
        private int _rear;

        public bool IsEmpty => _front == 0 && _rear == 0;
        public bool IsFull => !IsEmpty && _rear == _front;

        public ArrayQueue()
        {
            _queue = new int [5];
        }

        public void Enqueue(int item)
        {
            if (IsFull)
            {
                throw new IndexOutOfRangeException();
            }

            _queue[_rear] = item;
            _rear = (_rear + 1) % _queue.Length;

        }

        public int Dequeue()
        {
            if (IsEmpty)
            {
                throw new IndexOutOfRangeException();
            }
            var item = _queue[_front];
            _queue[_front] = 0;
            _front = (_front + 1) % _queue.Length;
            return item;
        }

        public int Peek()
        {
            if (IsEmpty)
            {
                throw new IndexOutOfRangeException();
            }

            return _queue[_front];
        }
    }
}