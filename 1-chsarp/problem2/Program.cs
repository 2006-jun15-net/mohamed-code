using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a program that prints a staircase of any size, taking the number from Console.ReadLine.

            Console.WriteLine("Please enter a number for the size of the staircase: ");
            string input = Console.ReadLine();
            int staircase = int.Parse(input);
            int spaces = staircase-1;

            for(int i=0; i<staircase; i++){
                for(int k=0; k<spaces; k++){
                    Console.Write(" ");
                }
                for(int j=0; j<=i; j++){
                    Console.Write("#");
                }
                Console.Write("\n");
                spaces--;
            }
        }
    }
}
