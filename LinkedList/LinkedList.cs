using System;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private Node First { get; set; }
        private Node Last { get; set; }

        private Node FirstPointer { get; set; }
        private Node SecondPointer { get; set; }

        private bool IsEmpty => First == null;

        //AddLast
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty)
            {
                First = Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }

        //AddFirst
        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty)
            {
                First = Last = node;
            }
            else
            {
                node.Next = First;
                First = node;
            }
        }

        public int IndexOf(int item)
        {
            var index = 0;
            var current = First;

            while (current != null)
            {
                if (current.Value == item)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(int item)
        {
            var current = First;

            while (current != null)
            {
                if (current.Value == item)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void DeleteFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No element in the List"); 
            }

            if (First == Last)
            {
                First = Last = null;
                return;
            }

            var second = First.Next;
            First.Next = null;
            First = second;
        }

        public void DeleteLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No element in the List");
            }

            if (First == Last)
            {
                First = Last = null;
                return;
            }

            var previous = GetPrevious(Last);
            Last = previous;
            Last.Next = null;
        }

        private Node GetPrevious(Node node)
        {
            var current = First;

            while (current != null)
            {
                if (current.Next == node)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }
        public int GetKthNodeFromTheEnd(int k)
        {
            FirstPointer = SecondPointer = First;

            for (var i = 0; i < k - 1; i++)
            {
                SecondPointer = SecondPointer.Next;
            }

            while (SecondPointer != Last)
            {
                FirstPointer = FirstPointer.Next;
                SecondPointer = SecondPointer.Next;
            }

            return FirstPointer.Value;

        }
    }
}