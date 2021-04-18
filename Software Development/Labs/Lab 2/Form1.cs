// Grading ID: J7618//
// Lab 2//
// Due Date: September 15 11:59 PM//
// CIS 199-01//
// Introduces students to GUI and how to code within them.//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcbtn_Click(object sender, EventArgs e)
        {
            //Creating constants for the percentage of tips.//
            const double TIPRATE_1 = .15;
            const double TIPRATE_2 = .18;
            const double TIPRATE_3 = .2;

            //Creating values for the user input, and for outputs down the line.//
            double check, //Creating a variable for the user input, price of the check.//
                tipcalcone, //Creating a variable for the future tip one calculation.//
                tipcalctwo, //Creating a variable for the future tip two calculation.//
                tipcalcthree; //Creating a variable for the future tip three calculation.//

            //Changing the user input text to a usable number.//
            check = double.Parse(pricetb.Text);

            //Calculating tip percentages, using user input and tip percentages.//
            tipcalcone = check * TIPRATE_1;
            tipcalctwo = check * TIPRATE_2;
            tipcalcthree = check * TIPRATE_3;

            //Displaying the end results calculated for certain tip percentages. 
            fifteencalc.Text = $"{tipcalcone:C}";
            eighteencalc.Text = $"{tipcalctwo:C}";
            twentycalc.Text = $"{tipcalcthree:C}";
        }
    }
}
