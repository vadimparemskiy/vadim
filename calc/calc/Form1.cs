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

           /* switch (((Button)sender).Name)
            {
                case "sum":
                    double result = secondValue + firstValue;
                    textBox3.Text = result.ToString();
                    //выполнение операции
                    break;
                case "sabtraction":
                    result = secondValue - firstValue;
                    textBox3.Text = result.ToString();
                    //выполнение операции
                    break;
                case "multyplication":
                    result = secondValue * firstValue;
                    textBox3.Text = result.ToString();
                    break;
                case "division":
                    result = secondValue / firstValue;
                    textBox3.Text = result.ToString();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
             
            }*/

        }
    }
}


