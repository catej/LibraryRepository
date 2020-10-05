using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresApp
{
    static class UI
    {
        public static Random rng = new Random();
        public static void DisplayMenu(string[] options, string prompt)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i}) {options[i]}");
            }
            System.Console.WriteLine($"{options.Length}) Exit");
            Console.Write(prompt + " ");
        }
        public static int GetInteger()
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("Not a valid number.");
                return -1;
            }
        }
        public static int ValidateInteger(int max, int min, int choice)
        {
            while (choice < min && choice > max)
            {
                Console.Write("Invalid Number.\n Please enter a number between {min} and {max}.");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    System.Console.WriteLine("");
                }
            }
            return choice;
        }
    }
}
