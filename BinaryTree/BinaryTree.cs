using System;
using System.Collections;
using System.Data;
using System.Linq;
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

        public int Height()
        {
            return Height(_root);
        }

        public int Min()
        {
            return Min(_root);
        }

        public bool Equals(BinaryTree tree)
        {
            return tree != null && Equals(_root, tree._root);
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(_root, int.MinValue, int.MaxValue);
        }

        public ArrayList GetKDistanceNodes(int k)
        {
            var array = new ArrayList();
            GetKDistanceNodes(k, _root, array);
            return array;
        }

        public void TraversLevelOrder()
        {
            for (var i = 0; i <= Height(_root); i++)
            {
                foreach (var node in GetKDistanceNodes(i))
                {
                    Console.WriteLine(node);
                }
            }
        }

        private void GetKDistanceNodes(int k, Node root, ArrayList arrayList)
        {
            if (root == null)
            {
                return;
            }

            if (k == 0)
            {
                arrayList.Add(root.Value);
                return;
            }

            GetKDistanceNodes(k - 1, root.RightChild, arrayList);
            GetKDistanceNodes(k - 1, root.LeftChild, arrayList);
        }

        private bool Equals(Node firstNode, Node secondNode)
        {
            if (firstNode == null && secondNode == null)
            {
                return true;
            }

            if(firstNode != null && secondNode != null)
            {
                return firstNode.Value == secondNode.Value 
                       && Equals(firstNode.LeftChild, secondNode.LeftChild) 
                       && Equals(firstNode.RightChild, secondNode.RightChild);
            }

            return false;
        }

        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.Value < min || root.Value > max)
            {
                return false;
            }

            return IsBinarySearchTree(root.LeftChild, min, root.Value - 1)
                   && IsBinarySearchTree(root.RightChild, root.Value + 1, max);
        }

        public int MinSearchBinaryTree()
        {
            if (_root == null)
            {
                throw new NoNullAllowedException();
            }

            var current = _root;
            var last = current;
            while (current != null)
            {
                last = current;
                current = current.LeftChild;
            }

            return last.Value;
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

        private int Height(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            if (root.LeftChild == null || root.RightChild == null)
            {
                return 0;
            }

            return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
        }

        private int Min(Node root)
        {
            if (root.LeftChild == null || root.RightChild == null)
            {
                return root.Value;
            }
            var left = Min(root.LeftChild);
            var right = Min(root.RightChild);

            return Math.Min(root.Value, Math.Min(left, right));
        }


    }
}