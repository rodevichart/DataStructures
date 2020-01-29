using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Hash_Tables;
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

            var list = new LinkedList.LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            Console.WriteLine(list.GetKthNodeFromTheEnd(3));

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

            //var stackQueue = new StackQueue(4);

            //stackQueue.Enqueue(10);
            //stackQueue.Enqueue(20);
            //stackQueue.Enqueue(30);
            //stackQueue.Enqueue(40);

            //Console.WriteLine(stackQueue.Dequeue());
            //Console.WriteLine(stackQueue.Dequeue());
            //Console.WriteLine(stackQueue.Dequeue());
            //stackQueue.Enqueue(35);
            //Console.WriteLine(stackQueue.Dequeue());
            //Console.WriteLine(stackQueue.Dequeue());
            //Console.WriteLine(stackQueue.Dequeue());

            #endregion

            #region PriorityQueue

            //var priorutyQueue = new PriorityQueue(2);
            //priorutyQueue.Insert(3);
            //priorutyQueue.Insert(1);
            //priorutyQueue.Insert(4);
            //priorutyQueue.Insert(6);
            //priorutyQueue.Insert(2);
            //priorutyQueue.Insert(5);

            //Console.WriteLine(priorutyQueue.Remove());

            #endregion

            #endregion

            #region Hash Tables

            //var employee = new Dictionary<int, string>();

            //employee.Add(1, "Artsem");
            //employee.Add(2, "Yura");
            //employee.Add(3, "Gary");



            //employee.ToList().ForEach(e => Console.WriteLine(e.Value));

            //Console.WriteLine(ParseString.GetFirstNonRepeatableCharacter("A Green Apple"));
            //Console.WriteLine(ParseString.GetFirstRepeatCharacter("Green Apple"));

            #region Custom HashTable

            //var hashTable = new HashTable(5);

            //hashTable.Put(6, "A");
            //hashTable.Put(8, "B");
            //hashTable.Put(11, "C");

            //Console.WriteLine(hashTable.Get(8));
            //Console.WriteLine(hashTable.Get(6));
            //Console.WriteLine(hashTable.Get(11));
            ////Console.WriteLine(hashTable.Get(10));

            //hashTable.Remove(11);

            #endregion

            #endregion

            #region Binary Tree

            var binaryTree = new BinaryTree.BinaryTree();
            //10, 5, 15, 6, 1, 8, 12, 18, 17
            binaryTree.Insert(10);
            binaryTree.Insert(5);
            binaryTree.Insert(15);
            binaryTree.Insert(6);
            binaryTree.Insert(1);
            binaryTree.Insert(8);
            binaryTree.Insert(12);
            binaryTree.Insert(18);
            binaryTree.Insert(17);

            Console.WriteLine(binaryTree.Find(8));
            #endregion
        }
    }
}
