using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class StackQueue
    {
        private Stack<int> _inputQueue;
        private Stack<int> _outputQueue;

        private bool IsQueuesEmpty => _inputQueue.Count == 0 && _outputQueue.Count == 0;

        public StackQueue(int capacity)
        {
            _inputQueue = new Stack<int>(capacity);
            _outputQueue = new Stack<int>(capacity);
        }

        public void Enqueue(int item)
        {
            _inputQueue.Push(item);
        }

        public int Dequeue()
        {
            if (IsQueuesEmpty)
            {
                throw new InvalidOperationException();
            }

            if (_outputQueue.Count == 0)
            {
                Reverse();
            }

            return _outputQueue.Pop();
        }

        private void Reverse()
        {
            while (_inputQueue.Count != 0)
                {
                    _outputQueue.Push(_inputQueue.Pop());
                }
        }
    }
}