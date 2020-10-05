using System;

namespace DataStructuresApp
{
    public class MyLinkedList
    {
        Node head;
        string[] methods = { "Display List", "Add node at end", "Remove node at end" };
        public void Exe()
        {
            SeedList();
            string prompt = "What would you like to do? ";
            string menu = UI.DisplayMenu(methods, prompt);
            int methodChoice = UI.ValidateInteger(0, methods.Length, menu);
            while(!methodChoice.Equals(methods.Length))
            {
                UseSelectedMethod(methodChoice);
                methodChoice = UI.ValidateInteger(0, methods.Length, menu);
            }
        }
        private void SeedList()
        {
            AddNodeAtEnd(UI.rng.Next(100));
            AddNodeAtEnd(UI.rng.Next(100));
            AddNodeAtEnd(UI.rng.Next(100));
        }
        private void UseSelectedMethod(int methodChoice)
        {
            switch (methodChoice)
            {
                case 0:
                    DisplayList();
                    break;
                case 1:
                    int numberToAdd = UI.ValidateInteger();
                    AddNodeAtEnd(numberToAdd);
                    break;
                case 2:
                    RemoveNodeAtEnd();
                    break;
            }
        }
        private void DisplayList()
        {
            if (head == null)
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
        }
        private void AddNodeAtEnd(int data)
        {
            Node temp = new Node (data);
            if (head == null)
            {
                head = temp;
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
        private void RemoveNodeAtEnd()
        {
            DisplayList();
            //find node before last: current.next.next == null
            if (head == null)
            {
                System.Console.WriteLine("List is already empty.");
            }
            else if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while(current.Next.Next != null)
                {
                    current = current.Next;
                }
                //set current.next to null :or: last.
                System.Console.WriteLine($"Node.Data: {current.Next.Data} successfully deleted.");
                current.Next = null;
                DisplayList();
            }
        }
    }
}