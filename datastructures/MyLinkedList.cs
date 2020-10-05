using System;

namespace DataStructuresApp
{
    public class MyLinkedList
    {
        Node head;
        string[] methods = { "Display List", "Add node at end", "Remove node at end", "Add node at beginning" };
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
            int numberToAdd;
            switch (methodChoice)
            {
                case 0:
                    DisplayList();
                    break;
                case 1:
                    numberToAdd = UI.ValidateInteger();
                    AddNodeAtEnd(numberToAdd);
                    break;
                case 2:
                    RemoveNodeAtEnd();
                    break;
                case 3:
                    numberToAdd = UI.ValidateInteger();
                    AddNodeAtBeginning(numberToAdd);
                    break;
            }
        }
        private void DisplayList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
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
            Console.WriteLine($"Node.Data: {node.Data}");
        }
        private void DisplayNodeAndNext(Node node)
        {
            Console.WriteLine($"Node.Data: {node.Data}");
            Console.WriteLine($"Node.Data: {node.Next.Data}");
        }
        private void AddNodeAtEnd(int data)
        {
            Node newNode = new Node (data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node last = head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newNode;
            }
        }
        private void RemoveNodeAtEnd()
        {
            if (head == null)
            {
                Console.WriteLine("List is already empty.");
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
                Console.WriteLine($"Node.Data: {current.Next.Data} successfully deleted.");
                current.Next = null;
                DisplayList();
            }
        }
        private void AddNodeAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node tempHead = head;
                newNode.Next = tempHead;
                head = newNode;
            }
        }

    }
}