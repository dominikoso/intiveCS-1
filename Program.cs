using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void FizzBuzz(int number){
                if (number % 2 == 0){
                    Console.Write("Fizz");
                }if(number % 3 == 0){
                    Console.Write("Buzz");
                }  
        }
        public static void Main(string[] args)
        {   
            FizzBuzz(3);
        }
    }
}
