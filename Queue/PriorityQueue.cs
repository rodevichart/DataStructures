using System;
using System.Linq;

namespace DataStructures.Queue
{
    public class PriorityQueue
    {
        private int[] _priorityQueue;
        private int _count;

        public bool IsEmpty => _count == 0;
        public bool IsFull => _count == _priorityQueue.Length;

        public PriorityQueue(int capacity)
        {
            _priorityQueue = new int[capacity];
        }

        public void Insert(int item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException();
            }

            if (_priorityQueue.Length == 1)
            {
                if (_priorityQueue[0] > item)
                {
                    _priorityQueue[0] = item;
                }
                return;
            }

            int i;
            for (i = _count - 1; i >= 0; i--)
            {
                if (_priorityQueue[i] > item)
                {
                    _priorityQueue[i + 1] = _priorityQueue[i];
                    _priorityQueue[i] = item;                   
                }
                else
                {
                    break;
                }
            }
            _priorityQueue[i + 1] = item;
            _count++;
        }

        public int Remove()
        {
            if (IsEmpty)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _priorityQueue[--_count];
        }
    }
}