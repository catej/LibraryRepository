namespace datastructures.structures
{
    public class TreeNode
    {
        public int data;
        public TreeNode leftSub;
        public TreeNode rightSub;

        public TreeNode(){}
        public TreeNode(int data)
        {
            this.data = data;
            leftSub = null;
            rightSub = null;
        }
    }
}