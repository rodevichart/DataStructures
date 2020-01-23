using System.Collections.Generic;

namespace DataStructures.Queue
{
    public static class QueueReverser
    {
        public static void Reverse(Queue<int> queue)
        {
            //add
            //remove
            //isEmpty
            var stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            
        }
    }
}