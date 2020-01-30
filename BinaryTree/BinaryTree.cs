using System;
using System.Runtime.Remoting.Messaging;

namespace DataStructures.BinaryTree
{
    public class BinaryTree
    {
        private Node _root;

        public void Insert(int value)
        {
            if (_root == null)
            {
                _root = new Node {Value = value};
                return;
            }

            var current = _root;
            var node = new Node {Value = value};

            while (true)
            {
                if (current.Value > value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        return;
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        return;
                    }
                    current = current.RightChild;
                }

            }
        }

        public bool Find(int value)
        {
            var current = _root;
            while (current != null)
            {
                if (current.Value > value)
                {
                    current = current.LeftChild;
                }
                else if(current.Value < value)
                {
                    current = current.RightChild;
                }
                else
                {
                    return true;
                }

            }

            return false;
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(_root);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(_root);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(_root);
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Value);
            TraversePreOrder(root.LeftChild);
            TraversePreOrder(root.RightChild);
        }

        private void TraverseInOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            
            TraverseInOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            TraverseInOrder(root.RightChild);
        }

        private void TraversePostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TraverseInOrder(root.LeftChild);
            TraverseInOrder(root.RightChild);
            Console.WriteLine(root.Value);
        }
    }
}