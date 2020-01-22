using System;
using System.Linq;

namespace DataStructures
{
    public class Stack
    {
        private int?[] _stack;
        private int _lastIndex = -1;

        public bool IsEmpty => _stack.All(s => !s.HasValue);
        private bool IsFull => _stack.All(s => s.HasValue);

        public Stack(int stackItems)
        {
            _stack = new int?[stackItems];
        }

        public void Push(int item)
        {
            if (IsFull)
            {
                var tempStack = _stack;
                _stack = new int?[tempStack.Length * 2];
                var index = 0;
                foreach (var element in tempStack)
                {
                    _stack[index++] = element;
                }
            }
            _stack[++_lastIndex] = item;
        }

        public int? Pop()
        {
            var item = _stack[_lastIndex];
            _stack[_lastIndex] = null;
            _lastIndex--;

            return item;
        }

        public int? Peek()
        {
           return _stack[_lastIndex];
        }
    }
}