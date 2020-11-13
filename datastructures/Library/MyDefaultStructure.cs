using System;
using DataStructuresApp;

namespace datastructures.structures
{
    public abstract class MyDefaultStructure
    {
        public Node head { get; set; }
        public int count { get; set; }
        public string[] methods { get; set; }
        public string structureName { get; set; }
        public MyDefaultStructure() {}
        public void Exe()
        {
            string prompt = $"You are using a: {structureName}.\n\nWhat would you like to do? ";
            string menu = UI.DisplayMenu(methods, prompt);
            int methodChoice;
            do
            {
                methodChoice = UI.ValidateInteger(0, methods.Length, menu);
                UseSelectedMethod(methodChoice);                
            }while(!methodChoice.Equals(methods.Length));
        }
        public abstract void SeedData();
        public abstract void UseSelectedMethod(int methodChoice);
        protected void DisplayList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Node current = head;
                for (int i = 0; i < count; i++)
                {
                    DisplayNode(current);
                    current = current.Next;
                }
            }
            Console.WriteLine($"Count: {count}");
        }
        protected void DisplayNode(Node node)
        {
            Console.WriteLine($"Node.Data: {node.Data}");
        }
        protected void DisplayNodeAndNext(Node node)
        {
            Console.WriteLine($"Node.Data: {node.Data}");
            Console.WriteLine($"Node.Data: {node.Next.Data}");
        }
        public void AddNodeAtEnd(int data)
        {
            Node newNode = new Node (data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node last = head;
                while(last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newNode;
            }
            count++;
        }
        public void RemoveNodeAtEnd()
        {
            if (head == null)
            {
                Console.WriteLine("List is already empty.");
            }
            else if (head.Next == null)
            {
                head = null;
                count--;
            }
            else
            {
                Node current = head;
                while(current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                count --;
            }
        }
        public void AddNodeAtBeginning(int data)
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
            count++;
        }
        public void RemoveNodeAtBeginning()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                head = head.Next;
                count--;
            }
        }
    }
}