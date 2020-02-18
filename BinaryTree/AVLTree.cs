namespace DataStructures.BinaryTree
{
    public class AVLTree
    {
        private AVLNode _root;

        public void Insert(int value)
        {

            _root = Insert(_root, value);
        }

        private AVLNode Insert(AVLNode root, int value)
        {
            if (root == null)
            {
                return new AVLNode(value); 
            }

            if (value < root.Value)
            {
                root.LeftChild = Insert(root.LeftChild, value);
            }
            else
            {
               root.RightChild = Insert(root.RightChild, value);
            }

            return root;
        }

    }
}