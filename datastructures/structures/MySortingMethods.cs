using System;
using DataStructuresApp;

namespace datastructures.structures
{
    public class MySortingMethods
    {
        public int[] everyOtherArrayToSort  = new int[] { 4, 10, 7, 8, 9, 6, 1, 5, 3, 2};
        public string[] methods = new string[] { "Bubble sort", "Quick sort" };
        public Random rng = new Random();
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
                    BubbleSort(everyOtherArrayToSort);
                    ResetArray();
                    break;
                case 1:
                    QuickSort(everyOtherArrayToSort);
                    ResetArray();
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
                if (item > 9)
                {
                    Console.Write($" {item} |");
                }
                else
                {
                    Console.Write($"  {item} |");
                }
            }
            Console.WriteLine();

        }
        private int[] BubbleSort(int[] newArray)
        {
            Console.Write("Starting ");
            PrintArray(newArray);

            int i, j, temp;
            for (i = newArray.Length - 2; i >= 0 ; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    if (newArray[j] > newArray[j + 1])
                    {
                        temp = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = temp;
                    }
                }
            }

            Console.Write("  Sorted ");
            PrintArray(newArray);
            return newArray;
        }
        
        private void QuickSort(int[] array)
        {
            Console.Write("Starting ");
            PrintArray(array);
            Console.Write("  Sorted ");
            QuickSort(array,0, array.Length - 1);
            PrintArray(array);
        }
        private void QuickSort(int[] array, int low, int up)
        {
            int n = array.Length - 1;

            if (low >= up)
            {
                return;
            }
            int p = Partition( array, low, up);
            QuickSort(array, low, p - 1);
            QuickSort(array, p + 1, up);

        }
        private int Partition(int[] array, int low, int up)
        {
            int temp, i, j, pivot;

            pivot = array[low];

            i = low + 1;
            j = up;

            while(i <= j)
            {
                while (array[i] < pivot && i < up)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                else
                {
                    break;
                }
            }

            array[low] = array[j];
            array[j] = pivot;
            
            return j;
        }
        private void ResetArray()
        {
            int[] array = new int[10]; 
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = rng.Next(100);
            }
            everyOtherArrayToSort = array;
        }
    }
}