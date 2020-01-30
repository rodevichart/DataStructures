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
    }
}