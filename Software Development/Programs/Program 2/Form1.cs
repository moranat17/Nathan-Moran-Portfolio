//Grading ID: J7618//
//Prog2//
//Due Date: October 16 11:59 PM//
//CIS 199-01//
//This program helps us get familiar with nested if, if else and else statements, while applying it to real life//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string day = ""; //Creating a blank variable for the day to register//
        string time = ""; //Creating a blank varaible for the time to register//


        private void Button1_Click(object sender, EventArgs e)
        {
            //Creating strings for each day that a student could schedule on, depending on their standing//
            string senday = "Monday, Nov 4";
            string junday = "Tuesday, Nov 5";
            string sophdayone = "Wednesday, Nov 6";
            string sophdaytwo = "Thursday, Nov 7";
            string freshdayone = "Friday, Nov 8";
            string freshdaytwo = "Monday, Nov 11";

            const double SEN_HOURS = 90; //Creating a variable for the hours needed for senior status//
            const double JUN_HOURS = 60; //Creating a variable for the hours needed for junior status//
            const double SOPH_HOURS = 30; //Creating a variable for the hours needed for sophomore status//

            char letter; //Creating a variable for the first letter in the student's last name//
            

            double hours; //Creating a variable for the hours a student has//

            if (double.TryParse(hourstext.Text, out hours))
            {
                if (char.TryParse(lettertext.Text.ToUpper(), out letter))
                {
                    if (hours >= SEN_HOURS)
                    {
                        if (letter <= 'D')
                        {
                            day = senday;
                            time = "11:30 AM";
                        }
                        else if (letter > 'D' && letter <= 'I')
                        {
                            day = senday;
                            time = "2:00 PM";
                        }
                        else if (letter > 'I' && letter <= 'O')
                        {
                            day = senday;
                            time = "4:00 PM";
                        }
                        else if (letter > 'O' && letter <= 'S')
                        {
                            day = senday;
                            time = "8:30 AM";
                        }
                        else
                        {
                            day = senday;
                            time = "10:00 AM";
                        }
               
                    }
                    else if (hours < SEN_HOURS && hours >= JUN_HOURS)
                    {
                        if (letter <= 'D')
                        {
                            day = junday;
                            time = "11:30 AM";
                        }
                        else if (letter > 'D' && letter <= 'I')
                        {
                            day = junday;
                            time = "2:00 PM";
                        }
                        else if (letter > 'I' && letter <= 'O')
                        {
                            day = junday;
                            time = "4:00 PM";
                        }
                        else if (letter > 'O' && letter <= 'S')
                        {
                            day = junday;
                            time = "8:30 AM";
                        }
                        else
                        {
                            day = junday;
                            time = "10:00 AM";
                        }
                    }
                    else if (hours < JUN_HOURS && hours >= SOPH_HOURS)
                    {
                        if (letter <= 'B')
                        {
                            day = sophdayone;
                            time = "4:00 PM";
                        }
                        else if (letter > 'B' && letter <= 'D')
                        {
                            day = sophdaytwo;
                            time = "8:30 AM";
                        }
                        else if (letter > 'D' && letter <= 'F')
                        {
                            day = sophdaytwo;
                            time = "10:00 AM";
                        }
                        else if (letter > 'F' && letter <= 'I')
                        {
                            day = sophdaytwo;
                            time = "11:30 AM";
                        }
                        else if (letter > 'I' && letter <= 'L')
                        {
                            day = sophdaytwo;
                            time = "2:00 PM";
                        }
                        else if (letter > 'L' && letter <= 'O')
                        {
                            day = sophdaytwo;
                            time = "4:00 PM";
                        }
                        else if (letter > 'O' && letter <= 'Q')
                        {
                            day = sophdayone;
                            time = "8:30 AM";
                        }
                        else if (letter > 'Q' && letter <= 'S')
                        {
                            day = sophdayone;
                            time = "10:00 AM";
                        }
                        else if (letter > 'S' && letter >= 'V')
                        {
                            day = sophdayone;
                            time = "11:30 AM";
                        }
                        else
                        {
                            day = sophdayone;
                            time = "2:00 AM";
                        }
                    }
                    else
                    {
                        if (letter <= 'B')
                        {
                            day = freshdayone;
                            time = "4:00 PM";
                        }
                        else if (letter > 'B' && letter <= 'D')
                        {
                            day = freshdaytwo;
                            time = "8:30 AM";
                        }
                        else if (letter > 'D' && letter <= 'F')
                        {
                            day = freshdaytwo;
                            time = "10:00 AM";
                        }
                        else if (letter > 'F' && letter <= 'I')
                        {
                            day = freshdaytwo;
                            time = "11:30 AM";
                        }
                        else if (letter > 'I' && letter <= 'L')
                        {
                            day = freshdaytwo;
                            time = "2:00 PM";
                        }
                        else if (letter > 'L' && letter <= 'O')
                        {
                            day = freshdaytwo;
                            time = "4:00 PM";
                        }
                        else if (letter > 'O' && letter <= 'Q')
                        {
                            day = freshdayone;
                            time = "8:30 AM";
                        }
                        else if (letter > 'Q' && letter <= 'S')
                        {
                            day = freshdayone;
                            time = "10:00 AM";
                        }
                        else if (letter > 'S' && letter >= 'V')
                        {
                            day = freshdayone;
                            time = "11:30 AM";
                        }
                        else
                        {
                            day = freshdayone;
                            time = "2:00 AM";
                        }
                    }
                }
            }

            //Displaying the day the student can register//
            dateoutputlabel.Text = $"{day}";

            //Displaying the time the student can register//
            timeoutputlabel.Text = $"{time}";


        }
    }
}
