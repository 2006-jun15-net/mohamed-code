using System;

namespace reverseString
{
    class Program 
    {
        static void Main()
        {
            Console.Write("Hello, please enter a string for me to reverse: ");
            String sentence = Console.ReadLine();
            String result = "";

            for(int i=sentence.Length-1; i>=0; i--){
                result += sentence[i];
            }

            Console.WriteLine("The reversed string is: "  + result);
        }
    }
}