//Grading ID: J7618//
//Program 1//
//Due Date: September 24 11:59 PM//
//CIS 199-01//
//Creates a program that uses user input to determine paint cans needed to paint a room.//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating constants for user input and usage down the line.//
            const double DOORMEASURE = 21; //Creating a changeable constant for the measurement of the doors.//
            const double WINDOWMEASURE = 12; //Creating a changeable constant for the measurement of the windows.//
            const double PAINTMEASURE = 400; //Creating a changeable constant for the paint one can holds.//

            //Creating strings to be used.//
            string totallengthAsString,
                heightAsString,
                doorsAsString,
                windowsAsString,
                coatsAsString;

            double totallength, //Creating a variable for the total length calculation.//
                height, //Creating a variable for the height calculation.//
                doors, //Creating a varaible for the door calculation.//
                windows, //Creating a varaible for the window calculation.//
                coats, //Creating a variable for amount of coats needed calculation.//
                paintcansneeded, //Creating a varaible for the total paint cans needed calculation.//
                paintcansrounded; //Creating a variable for the rounded amount of paint cans needed.//

            //Displaying lines to welcome the user and prompt inputs.//
            Console.WriteLine("Welcome to the Handy-Dandy Paint Estimator");
            Console.WriteLine("");

            //Prompting user input and turning it into a usable number.//
            Console.Write("Enter the total length of all walls (in feet): ");
            totallengthAsString = Console.ReadLine();
            Console.Write("Enter the height of the walls (in feet): ");
            heightAsString = Console.ReadLine();
            Console.Write("Enter the number of doors (non-neg int): ");
            doorsAsString = Console.ReadLine();
            Console.Write("Enter the number of windows (non-neg int): ");
            windowsAsString = Console.ReadLine();
            Console.Write("Enter the number of coats of paint (non-neg int): ");
            coatsAsString = Console.ReadLine();
            Console.WriteLine("");

            //Converting user input into a float type.//
            totallength = Convert.ToDouble(totallengthAsString);
            height = Convert.ToDouble(heightAsString);
            doors = Convert.ToDouble(doorsAsString);
            windows = Convert.ToDouble(windowsAsString);
            coats = Convert.ToDouble(coatsAsString);

            //Calculating outputs with given inputs and constants.//
            paintcansneeded = ((totallength * height - doors * DOORMEASURE - windows * WINDOWMEASURE) * coats) / PAINTMEASURE;
            paintcansrounded = (int)Math.Ceiling(paintcansneeded);

            //Displaying end results.//
            Console.WriteLine($"You need a minimum of {paintcansneeded:F1} gallons of paint");
            Console.WriteLine($"You'll need to buy {paintcansrounded} gallons, though");

        }
    }
}
