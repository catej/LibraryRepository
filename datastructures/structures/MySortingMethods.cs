using System;
using DataStructuresApp;

namespace datastructures.structures
{
    public class MySortingMethods
    {
        public int[] reversedToSort  = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        public int[] everyOtherArreyToSort  = new int[] { 4, 10, 7, 8, 9, 6, 1, 5, 3, 2};
        public string[] methods = new string[] { "Bubble sort", "Quick sort" };

                public void Exe()
        {
            string prompt = "What would you like to do? ";
            string menu = UI.DisplayMenu(methods, prompt);
            int methodChoice;
            do
            {
                methodChoice = UI.ValidateInteger(0, methods.Length, menu);
                UseSelectedMethod(methodChoice);                
            }while(!methodChoice.Equals(methods.Length));
        }
        public void UseSelectedMethod(int methodChoice)
        {
            // int arreyToSort;
            switch (methodChoice)
            {
                case 0:
                    BubbleSort(everyOtherArreyToSort);
                    break;
                case 1:
                    QuickSort(reversedToSort);
                    break;
                case 2:
                    Console.WriteLine("Exiting Sorting Methods...");
                    break;
            }
        }
        private void PrintArray(int[] array)
        {
            Console.Write("Array:");
            foreach (int item in array)
            {
                Console.Write($" {item} |");
            }
            Console.WriteLine();

        }
        private int[] BubbleSort(int[] array)
        {

            Console.Write("Starting ");
            PrintArray(array);

            int i, j, temp;
            for (i = array.Length - 2; i >= 0 ; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.Write("  Sorted ");
            PrintArray(array);
            return array;
        }
        
        private int[] QuickSort(int[] array)
        {
            
            Console.Write("Starting ");
            PrintArray(array);
            
            throw new NotImplementedException();

            Console.Write("Sorted ");
            PrintArray(array);
            return array;
        }
    }
}