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
        string[] dataStructures = { "Linked-List", "Stack", "Queue", "Misc_Methods" };
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Library App.");
            string prompt = "What library would you like to use? ";
            string menu = UI.DisplayMenu(dataStructures, prompt);

            int dataStructureChoice;
            do
            {
                // 1408: REMOVE HARD CODED CHOICE
                dataStructureChoice = UI.ValidateInteger(min, dataStructures.Length, menu);
                // dataStructureChoice = 1;
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
                    Console.Write("Exiting Library...");
                    break;
            }
        }
    }
}
