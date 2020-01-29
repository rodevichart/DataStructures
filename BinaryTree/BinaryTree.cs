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

            var item = SearchNode(value);
            item.Value = value;
        }

        private Node SearchNode(int value)
        {
            var current = _root;

            while (current != null)
            {
                if (current.Value > value)
                {
                    if (current.LeftChild == null)
                    {
                        return current.LeftChild = new Node();
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        return current.RightChild = new Node();
                    }
                    current = current.RightChild;
                }

            }

            return current;
        }

        public bool Find(int value)
        {
            var item = SearchNode(value);
            return item?.Value != 0;
        }
    }
}