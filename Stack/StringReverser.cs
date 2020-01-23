using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            var stack = new Stack<char>();

            foreach (var letter in input)
            {
                stack.Push(letter);
            }

            var stringBuilder = new StringBuilder();

            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop());
            }

            return stringBuilder.ToString();
        }

        public Stack<char> ReverseStackFromString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            var stack = new Stack<char>();

            foreach (var letter in input)
            {
                stack.Push(letter);
            }

            var reverseStack = new Stack<char>();

            while (stack.Count > 0)
            {
                reverseStack.Push(stack.Pop());
            }

            return reverseStack;
        }
    }
}