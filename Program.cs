using System;
using DataStructures.Queue;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linked List

            //var tempList = new LinkedList<int>();
            //tempList.AddLast(10);
            //tempList.AddLast(20);
            //tempList.AddLast(30);

            //foreach (var i in tempList)
            //{
            //    Console.WriteLine(i);
            //}

            //var list = new LinkedList();
            //list.AddLast(10);
            //list.AddLast(20);
            //list.AddLast(30);

            //list.AddFirst(5);

            //list.DeleteLast();

            //Console.WriteLine(list.IndexOf(45));
            //Console.WriteLine(list.Contains(20));

            #endregion

            #region Stack

            #region Reverse String

            //var str = "abcd";

            //var reversString = new StringReverser();

            //Console.WriteLine(reversString.Reverse(str));

            #endregion

            #region String Balancer

            //string input = "((<1> + <2>)) [a]";
            //string input = "(1 + 2)";
            //var stringBalancer = new StringBalancer();

            //Console.WriteLine(stringBalancer.IsStringBalanced(input));

            #endregion

            #region Stack from scratch

            //var stack = new Stack(2);

            //Console.WriteLine(stack.IsEmpty);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);


            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            #endregion

            #endregion

            #region Queues

            #region ReverseQueue

            //var queues = new Queue<int>();
            //queues.Enqueue(10);
            //queues.Enqueue(20);
            //queues.Enqueue(30);

            //QueueReverser.Reverse(queues);

            #endregion

            #region ArrayQueue

            //var arrayQueue = new ArrayQueue();

            //arrayQueue.Enqueue(10);
            //arrayQueue.Enqueue(20);
            //arrayQueue.Enqueue(30);
            //arrayQueue.Enqueue(40);

            //Console.WriteLine(arrayQueue.Dequeue());
            //Console.WriteLine(arrayQueue.Dequeue());

            //arrayQueue.Enqueue(50);
            //arrayQueue.Enqueue(60);
            //arrayQueue.Enqueue(70);

            #endregion

            #region StackQueue

            var stackQueue = new StackQueue(4);

            stackQueue.Enqueue(10);
            stackQueue.Enqueue(20);
            stackQueue.Enqueue(30);
            stackQueue.Enqueue(40);

            Console.WriteLine("stackQueue");
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            stackQueue.Enqueue(35);
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            #endregion


            #endregion
        }
    }
}
