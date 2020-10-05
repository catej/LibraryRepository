﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresApp
{
    static class UI
    {
        public static Random rng = new Random();
        public static string DisplayMenu(string[] options, string prompt)
        {
            string menu = "";
            for (int i = 0; i < options.Length; i++)
            {
                menu += i + ") " + options[i] + "\n";
            }
            menu += options.Length + ") Exit\n";
            menu += prompt;
            return menu;
        }
        public static int ValidateInteger()
        {
            int choice;
            try
            {
                Console.Write("Please enter an integer: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Error: not an integer.");
                return ValidateInteger();
            }
            return choice;
        }
        public static int ValidateInteger(int min, int max, string menuWithPrompt)
        {
            int choice = -1;
            try
            {
                do
                {
                    Console.WriteLine(menuWithPrompt);
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < min)
                    {
                        System.Console.WriteLine($"Error: {choice} is < {min}. Try again.");
                    }
                    else if (choice > max)
                    {
                        System.Console.WriteLine($"Error: {choice} is > {max}. Try again.");
                    }
                }while (choice < min || choice > max);
            }
            catch
            {
                System.Console.WriteLine("entered catch");
                Console.Write($"\nPlease enter a number between {min} and {max}.");
                return ValidateInteger(min, max, menuWithPrompt);
            }
            return choice;
        }
    }
}
