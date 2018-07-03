using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Click(object sender, EventArgs e)
        {
            string firstValuetext = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValuetext);
            string secondValuetext = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValuetext);

            string caluclateName = ((Button)sender).Name;

            ICalculateTwoArguments calculator = CalculateTwoFactory.CreateCalculate(caluclateName);
            double result = calculator.Calculate(firstValue, secondValue);
            textBox3.Text = result.ToString();

         
        }

        private void Click1(object sender, EventArgs e)
        {
            string firstValuetext = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValuetext);
            string caluclateName = ((Button)sender).Name;
            Ioneargument calculator = CalculatotOneFactory.CreateCalculate(caluclateName);
            double result = calculator.Calculate(firstValue);
            textBox3.Text = result.ToString();
        }
    }
}


