using System;

namespace ConsoleApp
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a string variable and get user input from the keyboard and store it in the variable
            Console.Write("What is your username: ");
            string? userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Pleased to meet you " + userName);
        }
    }
}