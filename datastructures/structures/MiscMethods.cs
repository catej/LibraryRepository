using System;
using DataStructuresApp;

namespace datastructures.structures
{
    public class MiscMethods
    {
        public string[] methods = new string[] { "Find Factorial", "Print Binary Octal Hexadecimal" , "Print Fibonacci", "Tower of Hanoi"};
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
            int numberToUse;
            // int position;
            switch (methodChoice)
            {
                case 0:
                    Factorial();
                    break;
                case 1:
                    numberToUse = UI.ValidateInteger();
                    PrintBinaryOctalHexadecimal(numberToUse);
                    break;
                case 2:
                    numberToUse = UI.ValidateInteger();
                    PrintFibonacci(numberToUse);
                    break;
                case 3:
                    numberToUse = UI.ValidateInteger();
                    TowerOfHanoi(numberToUse);
                    break;
                case 4:
                    System.Console.WriteLine("Exiting MiscMethods()...");
                    break;
            }
        }

        public void Factorial()
        {
            int numberToFactorial = UI.ValidateInteger();
            long factorial = FindFactorial(numberToFactorial);
            System.Console.WriteLine($"The factorial of {numberToFactorial} is {factorial}");
        }
        public long FindFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FindFactorial(n - 1);
            }
        }
        public void PrintBinaryOctalHexadecimal(int n)
        {
            long binary = Convert.ToInt64(Convert.ToString(n, 2));
            long oct = Convert.ToInt64(Convert.ToString(n, 8));
            long hex = Convert.ToInt64(Convert.ToString(n, 16));

            System.Console.WriteLine($"Your Number: {n}");
            System.Console.WriteLine($"Your Number in binary is: {binary}");
            System.Console.WriteLine($"Your Number in ocatal is: {oct}");
            System.Console.WriteLine($"Your Number in hexidecimal is: {hex}");
        }

        public void PrintFibonacci(int n)
        {
            // System.Console.Write(n);
            for (int i = 0; i <= n; i++)
            {
                Console.Write(GetNextNumber(i) + " ");
            }
        }
        public int GetNextNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return GetNextNumber(n - 1) + GetNextNumber(n - 2);
        }

        private void TowerOfHanoi(int n)
        {
            throw new NotImplementedException();
        }
    }
}