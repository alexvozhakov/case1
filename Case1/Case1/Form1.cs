using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Summ_Click(object sender, EventArgs e)
        {
           //double result = Convert.ToDouble(FirstArgumentField.Text) + Convert.ToDouble(SecondArgumentField.Text);
            double firstArgument = Convert.ToDouble(FirstArgumentField.Text);
            double secondArgument = Convert.ToDouble(SecondArgumentField.Text);
            Adder adder = new Adder();
            ThirdArgumentField.Text = adder.Calculate(firstArgument, secondArgument);

        }

        private void Deduc_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgumentField.Text) - Convert.ToDouble(SecondArgumentField.Text);
            ThirdArgumentField.Text = result.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgumentField.Text) / Convert.ToDouble(SecondArgumentField.Text);
            ThirdArgumentField.Text = result.ToString();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgumentField.Text) * Convert.ToDouble(SecondArgumentField.Text);
            ThirdArgumentField.Text = result.ToString();
        }
    }
}
