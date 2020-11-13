using System;
using System.Collections.Generic;
using System.Text;
using datastructures;
using datastructures.structures;


namespace DataStructuresApp
{
    public class Library
    {
        int min = 0;
        string[] dataStructures = { "Linked-List", "Stack", "Queue", "Misc Methods", "Binary Search Tree" };
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Library App.");
            string prompt = "What library would you like to use? ";
            string menu = UI.DisplayMenu(dataStructures, prompt);

            int dataStructureChoice;
            do
            {
                dataStructureChoice = UI.ValidateInteger(min, dataStructures.Length, menu);
                SelectDataStructure(dataStructureChoice);
            }while(dataStructureChoice != dataStructures.Length);

        }
        private void SelectDataStructure(int num)
        {   
            MyDefaultStructure structure;
            switch (num)
            {
                case 0:
                    structure = new MyLinkedList();
                    structure.Exe();
                    break;
                case 1:
                    structure = new MyStack();
                    structure.Exe();
                    break;
                case 2:
                    structure = new MyQueue();
                    structure.Exe();
                    break;
                case 3:
                    MiscMethods misc = new MiscMethods();
                    misc.Exe();
                    break;
                case 4:
                    MyBinarySearchTree tree = new MyBinarySearchTree();
                    tree.Exe();
                    break;
                case 5:
                    Console.Write("Exiting Library...");
                    break;
            }
        }
    }
}
