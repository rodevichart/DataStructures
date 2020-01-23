using System;
using System.Linq;

namespace DataStructures.Stack
{
    public class Stack
    {
        private int?[] _stack;
        private int _count = -1;

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
            _stack[++_count] = item;
        }

        public int? Pop()
        {
            if(_count == 0)
                throw new InvalidOperationException();
            var item = _stack[_count];
            _stack[_count] = null;
            _count--;

            return item;
        }

        public int? Peek()
        {
           return _stack[_count];
        }
    }
}