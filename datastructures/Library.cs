using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresApp
{
    public class Library
    {
        int min = 0;
        string[] dataStructures = { "Linked-List" };
        public void Start()
        {
            string prompt = "What library would you like to use? ";
            string menu = UI.DisplayMenu(dataStructures, prompt);

            // 1408: REMOVE HARD CODED CHOICE
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
                default:
                    System.Console.WriteLine("An error has occurred in Library/SelectDataStructure.cs");
                    break;
            }
        }
        
    }
}
