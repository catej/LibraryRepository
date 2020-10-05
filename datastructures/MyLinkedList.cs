namespace DataStructuresApp
{
    public class MyLinkedList
    {
        Node head;
        string[] methods = { "Display List", "Add node end" };
        public void Exe()
        {
            SeedList();
            System.Console.WriteLine("List seeded with 3 Nodes with random numbers < 10.");
            DisplayMethods();
        }
        private void SeedList()
        {
            AddNodeAtEnd(UI.rng.Next(10));
            AddNodeAtEnd(UI.rng.Next(10));
            AddNodeAtEnd(UI.rng.Next(10));
        }
        private void DisplayMethods()
        {
            string prompt = "What would you like to do?";
            UI.DisplayMenu(methods, prompt);
        }
        private void AddNodeAtEnd(int data)
        {
            Node temp = new Node (data);
            if (this.head == null)
            {
                this.head = temp;
            }
            else
            {
                Node last = head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = temp;
            }
        }
        private void DisplayList()
        {
            if (this.head == null)
            {
                System.Console.WriteLine("The list is empty.");
            }
            else
            {
                Node current = head;
                DisplayNode(current);
                while(current.Next != null)
                {
                    current = current.Next;
                    DisplayNode(current);
                }
            }
        }
        private void DisplayNode(Node node)
        {
            System.Console.WriteLine($"Node.data: {node.Data}");
            if (node.Next != null)
            {
                System.Console.WriteLine($"Node.next: {node.Next}");
            }
            else
            {
                System.Console.WriteLine("Node.next: No next node!");
            }
        }
    }
}