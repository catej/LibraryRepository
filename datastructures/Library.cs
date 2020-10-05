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
            UI.DisplayMenu(dataStructures, "What would you like to work with?");
            int dataStructureChoice = UI.GetInteger();
            int validChoice = UI.ValidateInteger(min, dataStructures.Length, dataStructureChoice);
            SelectDataStructure(validChoice);
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
                    System.Console.WriteLine("Exiting Library...\n");
                    break;
            }
        }
        
    }
}
