using System;
using System.Collections.Generic;
using System.Text;
using datastructures;

namespace DataStructuresApp
{
    public class Library
    {
        string[] dataStructures = { "Linked-List", "Stack", "Queue" };
        public void Start()
        {
            Console.WriteLine("Welcome to the Library App.");
            string prompt = "What library would you like to use? ";
            string menu = UI.DisplayMenu(dataStructures, prompt);

            int dataStructureChoice = 1;
            while(dataStructureChoice != dataStructures.Length)
            {
                // 1408: REMOVE HARD CODED CHOICE
                // int min = 0;
                // int dataStructureChoice = UI.ValidateInteger(min, dataStructures.Length, menu);
                dataStructureChoice = 1;
                SelectDataStructure(dataStructureChoice);
            }

        }
        private void SelectDataStructure(int num)
        {   
            switch (num)
            {
                
                case 0:
                    MyLinkedList linkedList = new MyLinkedList();
                    linkedList.Exe();
                    break;
                case 1:
                    MyStack myStack = new MyStack();
                    myStack.Exe();
                    break;
                case 2:
                    MyQueue myQueue = new MyQueue();
                    myQueue.Exe();
                    break;
                case 3:
                    Console.Write("Exiting Library...");
                    break;
            }
        }
    }
}
