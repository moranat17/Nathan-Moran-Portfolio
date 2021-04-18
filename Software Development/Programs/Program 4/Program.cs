// Grading ID: J7618
// Program 4
// CIS 199-01
// Due: 12/03/2019
// This program is meant to utilize get;set; and as well as additional classes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            //library book 1 object
            LibraryBook libraryBook1 = new LibraryBook("Moby Dick", "Herman Melville", "Richard Bentley", 1851, "J987.6543", false);

            //library book 2 object
            LibraryBook libraryBook2 = new LibraryBook("Catching Fire", "Suzanne Collins", "Scholastic Corporation", 2009, "J012.3249", false);

            //library book 3 object
            LibraryBook libraryBook3 = new LibraryBook("The City of Ember", "Jeanne DuPrau", "Yearling", 2003, "J9999.888", false);

            //library book 4 object
            LibraryBook libraryBook4 = new LibraryBook("Lord of the Flies", "William Golding", "Faber and Faber", 1954, "J7394.5937", false);

            //library book 5 object
            LibraryBook libraryBook5 = new LibraryBook("Fahrenheit 451", "Ray Bradbury", "Simon & Schuster", 1953, "J4759.7459", false);


            //array with library book objects
            object[] bookArray = { libraryBook1, libraryBook2, libraryBook3, libraryBook4, libraryBook5 };

            //for loop that prints objects contents on the console
            for (int x = 0; x < bookArray.Length; x++)
            {
                WriteLine($"Book {x + 1} information:");
                Write(bookArray[x].ToString());
                WriteLine("");
            }

            WriteLine();
            WriteLine();
            WriteLine();

            //changes made to 
            libraryBook1.CheckOut();
            libraryBook2.Publisher = "Nathan Moran";
            libraryBook3.CallNumber = "J123.4567";
            libraryBook4.CheckOut();
            libraryBook5.Publisher = "Moran Books";


            //for loop that prints objects contents on the console
            for (int x = 0; x < bookArray.Length; x++)
            {
                WriteLine($"Book {x + 1} information after books have been checked out and changes to Publisher/Call number have been made:");
                Write(bookArray[x].ToString());
                WriteLine("");

            }

            WriteLine();
            WriteLine();
            WriteLine();


            libraryBook1.ReturnToShelf();
            libraryBook4.ReturnToShelf();


            //for loop that prints objects contents on the console
            for (int x = 0; x < bookArray.Length; x++)
            {
                WriteLine($"Book {x + 1} information after books have been returned:"); ;
                Write(bookArray[x].ToString());
                WriteLine("");

            }
        }
    }
}
