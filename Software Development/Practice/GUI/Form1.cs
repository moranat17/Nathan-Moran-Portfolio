using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Practice
{
    public partial class FirstNumTB : Form
    {
        public FirstNumTB()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;

            num1 = double.Parse(FirstNum.Text);
            num2 = double.Parse(SecondNum.Text);

            sum = num1 + num2;

            calculation.Text = $"{sum:F2}";
        }
    }
}
