//Grading ID: J7618//
//Lab 5//
//Due Date: October 20, 11:59 PM//
//CIS 199 - 01//
//This program gets us familiar with nested loops//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10; //Declaring variable for max rows//

            Console.WriteLine("Pattern A \n");

            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine("");
            }

            Console.Write("\n");
            Console.WriteLine("Pattern B \n");

            const int MIN_ROWS = 1; //Declaring variable for max rows//

            for (int row = 10; row >= MIN_ROWS; row--)
            {
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine("");
            }

            Console.Write("\n");
            Console.WriteLine("Pattern C \n");

            int a, b, c; //Declaring variable for usage later//

            for (a = 10; a >= 1; a--)
            {
                for (b = 10; b > a; b--)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= a; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Write("\n");
            Console.WriteLine("Pattern D \n");

            int d, e, f; //Declaring variable for usage later//

            for (d = 10; d >= 1; d--)
            {
                for (e = 1; e < d; e++)
                {
                    Console.Write(" ");
                }
                for (f = 10; f >= d; f--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
