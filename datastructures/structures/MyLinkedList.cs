using System;
using datastructures.structures;

namespace DataStructuresApp
{
    public class MyLinkedList : MyDefaultStructure
    {
        
        string[] methods = { "Display List", "Add node at end", "Remove node at end", "Add node at beginning", "Remove node at beginning", "Add at Nth", "Remove at Nth", "Reverse List", "Bubble sort | Exchange data", "Bubble Sort | Exchange links", "Insert Cycle", "Detect cycle", "Remove Cycle" }; // add to UseSelectedMethod() : switch

        // public void Exe()
        // {
        //     SeedList();
        //     string prompt = "You are using a: Linked List.\n\nWhat would you like to do? ";
        //     string menu = UI.DisplayMenu(methods, prompt);
        //     int methodChoice = UI.ValidateInteger(0, methods.Length, menu);
        //     while(!methodChoice.Equals(methods.Length))
        //     {
        //         UseSelectedMethod(methodChoice);
        //         methodChoice = UI.ValidateInteger(0, methods.Length, menu);
        //     }
        // }
        public override void SeedData()
        {
            // AddNodeAtEnd(UI.rng.Next(100));
            AddNodeAtEnd(1);
            AddNodeAtEnd(2);
            AddNodeAtEnd(10);
            AddNodeAtEnd(3);
            AddNodeAtEnd(7);
            AddNodeAtEnd(5);
            AddNodeAtEnd(4);
            AddNodeAtEnd(6);
            AddNodeAtEnd(8);
            AddNodeAtEnd(9);
        }
        public override void UseSelectedMethod(int methodChoice)
        {
            int numberToAdd;
            int position;
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
                case 4:
                    RemoveNodeAtBeginning();
                    break;
                case 5: 
                    numberToAdd = UI.ValidateInteger();
                    position = UI.ValidateInteger(0,"Please enter a position >= 0: ");
                    AddNodeAtNth(position, numberToAdd);
                    break;
                case 6: 
                    if(count > 0)
                    {
                        string prompt = $"Please enter a number (0 - {count -1}): ";
                        position = UI.ValidateInteger(0, count - 1, prompt);
                        RemoveNodeAtNth(position);
                    }
                    else
                    {
                        Console.WriteLine("List is empty.");
                    }
                    break;
                case 7: 
                    ReverseList();
                    break;
                case 8: 
                    BubbleSortData();
                    break;
                case 9: 
                    BubbleSortLinks();
                    break;
                case 10:
                    if(count > 1)
                    {
                        string prompt = $"Please enter a number (0 - {count - 2}): ";
                        position = UI.ValidateInteger(0, count - 2, prompt);
                        InsertCycle(position);
                    }
                    else
                    {
                        Console.WriteLine("List Only contains 1 element");
                    }
                    break;
                case 11: 
                    DetectCycle();
                    break;
                case 12: 
                    RemoveCycle();
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
                for (int i = 0; i < count; i++)
                {
                    DisplayNode(current);
                    current = current.Next;
                }
            }
            Console.WriteLine($"Count: {count}");
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
                while(last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newNode;
            }
            count++;
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
            count++;
        }
        private void RemoveNodeAtBeginning()
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
        private void AddNodeAtNth(int position, int data)
        {
            Node currentNode;
            Node previous;
            if(position == 0)
            {
                AddNodeAtBeginning(data);
            }
            else if (position == count)
            {
                AddNodeAtEnd(data);
            }
            else if (position > count)
            {
                Console.WriteLine($"Position {position} does not exist.\nThere are only {count - 1} positions");
            }
            else
            {
                int currentPosition = 0;
                previous = null;
                currentNode = head;

                Node Temp = new Node(data);
                while (currentPosition <  position)
                {
                    previous = currentNode;
                    currentNode = currentNode.Next;
                    if (currentNode == null)
                    {
                        break;
                    }
                    currentPosition ++;
                }
                Temp.Next = currentNode;
                previous.Next = Temp;
                count++;
            }
        }
        private void RemoveNodeAtNth(int position)
        {
            System.Console.WriteLine($"Position: {position}");
            int length = count - 1;
            if(head != null && position == 0)
            {
                RemoveNodeAtBeginning();
            }
            else if (position == length)
            {
                RemoveNodeAtEnd();
            }
            else
            {
                Node previous = null;
                Node currentNode = head;
                int currentPosition = 0;
                while(currentPosition < position)
                {
                    previous = currentNode;
                    currentNode = currentNode.Next;
                    if (currentNode == null)
                    {
                        break;
                    }
                    currentPosition++;
                }
                previous.Next = currentNode.Next;
                count--;
            }
        }
        private void ReverseList()
        {
            Node previousNode = null;
            Node currentNode = head;
            Node next = null;
            while(currentNode != null)
            {
                next = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = next;
            }
            head = previousNode;
        }
        private void BubbleSortData()
        {
            if (head == null)
            {
                return;
            }
            else if (head.Next == null)
            {
                return;
            }
            else
            {
                Node endNode;
                Node currentNode;
                Node nextNode;
                for(endNode = null; endNode != head.Next; endNode = currentNode)
                {
                    for (currentNode = head; currentNode.Next != endNode; currentNode = currentNode.Next)
                    {
                        nextNode = currentNode.Next;
                        if (currentNode.Data > nextNode.Data)
                        {
                            int temp = currentNode.Data;
                            currentNode.Data = nextNode.Data;
                            nextNode.Data = temp;
                        }
                    }
                }
            }
        }
        private void BubbleSortLinks()
        {
            if (head == null)
            {
                return;
            }
            else if (head.Next == null)
            {
                return;
            }
            else
            {
                Node endNode, currentNode, previousNode, nextNode, temp;
                for(endNode = null; endNode != head.Next; endNode = currentNode)
                {
                    for (previousNode = currentNode = head; currentNode.Next != endNode; previousNode = currentNode, currentNode = currentNode.Next)
                    {
                        nextNode = currentNode.Next;
                        if (currentNode.Data > nextNode.Data)
                        {
                            currentNode.Next = nextNode.Next;
                            nextNode.Next = currentNode;
                            if (currentNode != head)
                            {
                                previousNode.Next = nextNode;
                            }
                            else
                            {
                                head = nextNode;
                            }
                            temp = currentNode;
                            currentNode = nextNode;
                            nextNode = temp;
                        }
                    }
                }
            }
        }
        private void InsertCycle(int cycleTarget)
        {
            if (cycleTarget == 0 && count == 2)
            {
                if (DetectCycle() == false)
                {
                    head.Next.Next = head;
                }
                else
                {
                    Console.WriteLine("Cycle already exists.");
                }
            }
            else
            {

                Node current = head;
                Node targetNode = null;
                for(int i = 0; i < count - 1; i++)
                {
                    if (i == cycleTarget)
                    {
                        targetNode = current;
                    }
                    current = current.Next;
                }
                DisplayNode(targetNode);
                DisplayNode(current);
                current.Next = targetNode;
            }
        }
        private bool DetectCycle()
        {
            int? cycleStart = FindCycle();
            if (cycleStart == null)
            {
                Console.WriteLine("No cycle detected.");
                return false;
            }
            else
            {
                Console.WriteLine($"Cycle detected at position: {cycleStart}.");
                return true;
            }
        }
        private int? FindCycle()
        {
            if (head == null || head.Next == null) 
            { 
                return null; 
            }
            Node current = head;
            Node counterNode = head;
            int position = 0;
            for(int i = 0; i < count - 1; i++)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("No Cycle");
                return null;
            }
            else
            {
                while (counterNode != current.Next)
                {
                    position++;
                    counterNode = counterNode.Next;
                }
                return position;
            }
        }
        private void RemoveCycle()
        {
            // throw new NotImplementedException();

            if (FindCycle() == null)
            {
                Console.WriteLine("No cycle detected.");
            }
            else
            {
                Node current = head;
                for(int i = 0; i < count - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }

    }
}