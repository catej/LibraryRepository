namespace DataStructuresApp
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
        public Node(int data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}