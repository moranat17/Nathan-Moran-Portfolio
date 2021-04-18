//Grading ID: J7618//
//Lab 6//
//Due Date: October 27, 11:59 PM//
//CIS 199 - 01//
//This program gets us familiar with arrays and range matching//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcbutton_Click(object sender, EventArgs e)
        {
            int[] NumWordsTyped = { 0, 16, 31, 51, 76 }; //Words typed for array//
            char[] letterGrade = { 'F', 'D', 'C', 'B', 'A' }; //Letter grades for the array//
            int wordsTyped; //Words typed variable//
            bool found = false; //Bool variable//
            char finalGrade; //Final grade variable//

            if (int.TryParse(wordstyped.Text, out wordsTyped))
            {
                int index = NumWordsTyped.Length - 1;

                while (index >= 0 && !found)
                {
                    if (wordsTyped >= NumWordsTyped[index])
                        found = true;
                    else --index;
                }

                if (found)
                {
                    finalGrade = letterGrade[index];

                    gradeoutputlabel.Text = $"{finalGrade}";
                }
                else
                {
                    MessageBox.Show("Not Found"); //Not found message//
                }
            }
            else
                MessageBox.Show("Invalid Input. Try Again."); //Input error message box//
        }
    }
}
