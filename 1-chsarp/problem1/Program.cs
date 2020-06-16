using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. if this is a staircase of size 3:
                #
                ##
                ###
                    make a program that prints a staircase of size 8.
                    (it should ascend up to the right, not descend down to the right.)
            */

            for(int i=1; i<9; i++){
                for(int j=0; j<i; j++){
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
