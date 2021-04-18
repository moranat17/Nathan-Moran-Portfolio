// Grading ID: J7618
// Lab 7
// CIS 199-01
// Due: 11/10/2019
// This program goes over value-returning methods with an intro to pre and post conditions. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double FV, AIR, NOY, PV; //Create variables for the inputs

            if (double.TryParse(FVInput.Text, out FV) && FV > 0) //Tryparsing the fv input for use
            {
                if (double.TryParse(AIRInput.Text, out AIR) && AIR > 0) //Tryparsing the air input for use
                {
                    if (double.TryParse(NOYInput.Text, out NOY) && NOY > 0) //Tryparsing the noy input for use
                    {
                        PV = FV / Math.Pow(1 + AIR, NOY); //Calculating the present value
                        OutputLabel.Text = $"{PV:C}"; //Outputing the present value in currency form
                    }
                    else
                        MessageBox.Show("Invalid Future Value; Must Be Greater Than 0"); //Error message if fv is below 0
                }
                else
                    MessageBox.Show("Invalid Interest Rate; Must Be Greater Than 0"); //Error message if air is below 0
            }
            else
                MessageBox.Show("Invalid Year; Must Be Greater Than 0"); //Error message if noy is below 0
        }
    }
}
