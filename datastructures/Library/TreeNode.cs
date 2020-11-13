namespace datastructures.structures
{
    public class TreeNode
    {
        int data;
        TreeNode leftSub;
        TreeNode rightSub;

        public DefaultTree(int data)
        {
            this.data = data;
            leftSub = null;
            rightSub = null;
        }
    }
}