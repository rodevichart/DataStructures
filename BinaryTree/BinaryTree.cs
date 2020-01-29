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

            //var current = _root;
            var node = new Node {Value = value};

            var item = SearchNode(value);
            item = node;

            //while (current != null)
            //{
            //    if (current.Value > value)
            //    {
            //        if (current.LeftChild == null)
            //        {
            //            current.LeftChild = node;
            //            return;
            //        }
            //        current = current.LeftChild;
            //    }
            //    else
            //    {
            //        if (current.RightChild == null)
            //        {
            //            current.RightChild = node;
            //            return;
            //        }
            //        current = current.RightChild;
            //    }

            //}
        }

        private Node SearchNode(int value)
        {
            var current = _root;
            //var node = new Node { Value = value };

            while (current != null)
            {
                if (current.Value > value)
                {
                    if (current.LeftChild == null)
                    {
                        return current.LeftChild;
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        return current.RightChild;
                    }
                    current = current.RightChild;
                }

            }

            return current;
        }
    }
}