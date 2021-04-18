//Grading ID: J7618//
//Lab 4//
//Due Date: September 29 11:59 PM//
//CIS 199-01//
//This lab helps us get used to to TryParse and If statements.//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        string status = "";//Creating a blank variable for the status.//
        int TOTAL_ACCEPT = 0;//Creating a variable for the accepted count.//
        int TOTAL_DENY = 0;//Creating a variable for the rejected count.//

        private void Admitbutton_Click(object sender, EventArgs e)
        {
            //Creating constants for the average gpa needed and low and high test scores.//
            const double AVERAGE_GPA = 3.0;
            const int LOW_TEST_SCORE = 60;
            const int HIGH_TEST_SCORE = 80;

            double gpa; //Creating a varaible for the GPA.//

            int testscore; //Creating a variable for the test score.//

            //Creating if statements with TryParse that determine Accepted or Denied.//
            if (double.TryParse(gpatextbox.Text, out gpa))
            {
                if(int.TryParse(admtesttextbox.Text, out testscore))
                {
                    if (gpa >= AVERAGE_GPA && testscore >= LOW_TEST_SCORE)
                    {
                        status = "Accepted";
                    }
                    else if (gpa < AVERAGE_GPA && testscore >= HIGH_TEST_SCORE)
                    {
                        status = "Accepted";
                    }
                    else
                        status = "Rejected";
                }
            }

            //Displaying the status of the student.//
            answerlabel.Text = $"{status}";

            //Creating the if statement to count total accepted.//
            if (status == "Accepted")
            {
                TOTAL_ACCEPT = (TOTAL_ACCEPT + 1);
            }

            //Displaying the accepted count.//
            acceptcount.Text = $"{TOTAL_ACCEPT}";

            //Creating the if statement to count total rejected.//
            if (status == "Rejected")
            {
                TOTAL_DENY = (TOTAL_DENY + 1);
            }

            //Displaying the rejected count.//
            denycount.Text = $"{TOTAL_DENY}";
        }
    }
}
