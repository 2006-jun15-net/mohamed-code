using System;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3. make a program that prints the Collatz sequence (up until 1) for a given number,
            taking the number from Console.ReadLine.
            for any number n, the next number in its Collatz sequence is:
            - if n is even, it is n divided by two.
            - if n is odd, it is n times three, plus one.
            for example, for 10, you should print:
                10
                5
                16
                8
                4
                2
                1 */

            Console.WriteLine("Please enter a number: ");
            string n = Console.ReadLine();
            int x = int.Parse(n);
            while(x!=1){
                if(x%2==0){
                    x/=2;
                    Console.WriteLine(x);
                }else{
                    x = (x*3)+1;
                    Console.WriteLine(x);
                }        
            }

        }
    }
}
