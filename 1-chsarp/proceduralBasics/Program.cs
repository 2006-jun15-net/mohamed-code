using System;

namespace proceduralBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number fag: ");

            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

            Console.WriteLine("You entered: "+ number);
        }
    }
}
