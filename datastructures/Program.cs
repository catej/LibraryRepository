using System;

namespace DataStructuresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.Start();
            System.Console.Write("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
