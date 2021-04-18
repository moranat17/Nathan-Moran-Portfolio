//Grading ID: J7618//
//Lab 3//
//Due Date: September 22 11:59 PM//
//Utilizes GUI's and pictureboxes to create a functional GUI.//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Creating values for the user input, and for outputs down the line.//
            double radius, //Creating a variable for the user input, the radius of the circle.//
                diametercalc, //Creating a variable for the future diameter calculation.//
                surfaceareacalc, //Creating a variable for the future surface area calculation.//
                volumecalc; //Creating a variable for the future volume calculation.//

            //Changing the user input to a usable number.//
            radius = double.Parse(radiusinput.Text);

            //Calculating the different outputs using the user input.//
            diametercalc = radius * 2;
            surfaceareacalc = 4 * Math.PI * Math.Pow(radius, 2);
            volumecalc = (4 * Math.PI * Math.Pow(radius, 3))/3;

            //Displaying the end results calculated.//
            diameter.Text = $"{diametercalc:F2}";
            surfacearea.Text = $"{surfaceareacalc:F2}";
            volume.Text = $"{volumecalc:F2}";

        }
    }
}
