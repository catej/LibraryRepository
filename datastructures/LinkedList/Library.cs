using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresApp
{
    public class Library
    {
        string[] dataStructures = { "Linked-List" };
        public void Start()
        {
            Console.WriteLine("Welcome to the Library App.");
            string prompt = "What library would you like to use? ";
            string menu = UI.DisplayMenu(dataStructures, prompt);

            // 1408: REMOVE HARD CODED CHOICE
            // int min = 0;
            // int dataStructureChoice = UI.ValidateInteger(min, dataStructures.Length, menu);
            int dataStructureChoice = 0;

            SelectDataStructure(dataStructureChoice);
            System.Console.Write("Exiting Library...");
        }
        private void SelectDataStructure(int num)
        {   
            switch (num)
            {
                case 0:
                    MyLinkedList structure = new MyLinkedList();
                    structure.Exe();
                    break;
                case 1:
                    break;
                default:
                    System.Console.WriteLine("An error has occurred in Library/SelectDataStructure.cs");
                    break;
            }
        }
        
    }
}
