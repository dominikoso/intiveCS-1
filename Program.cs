using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void WaitForKey(ConsoleKey key)
        {
            while (Console.ReadKey(true).Key != key)
            { }
        }
        public static void FizzBuzz(int number)
        {
            if (number > 1000 || number < 0)
            {
                Console.WriteLine("Invalid number specified. Please select number from 0 to 1000");
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.Write("Fizz");
                }
                if (number % 3 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine();
            }
        }

        public static void DeepDive(int number)
        {

        }
        public static void DropItDown(int number)
        {

        }
        public static void Exit()
        {
            System.Environment.Exit(1);
        }
        public static void generateMenu()
        {
            Console.WriteLine("Select Option:");
            Console.WriteLine("--------------");
            Console.WriteLine("1. FizzBuzz");
            Console.WriteLine("2. DeepDive");
            Console.WriteLine("3. DropItDown");
            Console.WriteLine("4. Exit");
            selectOption();
        }
        public static void selectOption()
        {
            try
            {
                string selected = Console.ReadLine();
                if (selected == "1")
                {
                    Console.WriteLine("Enter the number (0-1000):");
                    string input = Console.ReadLine();
                    if (Int32.TryParse(input, out int number))
                    {
                        FizzBuzz(number);
                    }
                    else
                    {
                        throw new System.ArgumentException("Parameter must be int");
                    }
                }
                else if (selected == "2") { Console.WriteLine("Not implemented yet"); }
                else if (selected == "3") { Console.WriteLine("Not implemented yet"); }
                else if (selected == "4") { Exit(); }
                else { Console.WriteLine("Invalid Option"); }
                Console.Write("Press 'Y' to continue.");
                WaitForKey(ConsoleKey.Y);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exception Occured xD");
            }
        }


        public static void Main(string[] args)
        {
            while (true)
            {
                generateMenu();
                Console.Clear();
            }
        }
    }
}
