using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Case1.BinaryCalculators;
using Case1.FirstCalculations;
using Case1.MassSort;

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
            HotDog("Add");
        }

        private void Deduc_Click(object sender, EventArgs e)
        {
            HotDog("Ded");
        }

        private void Div_Click(object sender, EventArgs e)
        {
            HotDog("Sub");
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            HotDog("Mult");
        }

        private void HotDog(string name )
        {
            double firstArgument = Convert.ToDouble(FirstArgumentField.Text);
            double secondArgument = Convert.ToDouble(SecondArgumentField.Text);
            IBinaryCalculation binaryCalculation = FactoryClass.CreateOperation(name);
            ThirdArgumentField.Text = binaryCalculation.Calculate(firstArgument, secondArgument).ToString();
        }

        private void Sandwitch(string name)
        {
            double firstArgument = Convert.ToDouble(FirstArgumentField.Text);
            IOneCalculation firstCalculation = FactoryClass2.CreateOperation(name);
            ThirdArgumentField.Text = firstCalculation.Calculate(firstArgument).ToString();
        }

        private void sin_Click(object sender, EventArgs e)
        {
            Sandwitch("Sin");
        }

        private void cos_Click(object sender, EventArgs e)
        {
            Sandwitch("Cos");
        }

        private void tan_Click(object sender, EventArgs e)
        {
            Sandwitch("Tan");
        }

        private void cotan_Click(object sender, EventArgs e)
        {
            Sandwitch("Ctan");
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Sandwitch("Sqrt");
        }

        private void pow_Click(object sender, EventArgs e)
        {
            HotDog("Pow");
        }

        private void pow2_Click(object sender, EventArgs e)
        {
            Sandwitch("Powsqr");
        }

        private void log10_Click(object sender, EventArgs e)
        {
            Sandwitch("log10");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sandwitch("Acos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sandwitch("Asin");
        }

        private void Atan_Click(object sender, EventArgs e)
        {
            Sandwitch("Atan");
        }

        private void ln_Click(object sender, EventArgs e)
        {
            Sandwitch("ln");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hamburger("Bubble");
        }

        private void Hamburger(string name)
        {
            string[] stringArray = FirstArgumentField.Text.Split(' ');
            int[] array = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                array[i] = Convert.ToInt32(stringArray[i]);
            }
            ISort sorter = FactorySort.CreateOperation(name);
            int[] result = sorter.SortMass(array);
            string stringResult = string.Empty;
            foreach (int element in result)
            {
                stringResult += element + " ";

            }
            ThirdArgumentField.Text = stringResult;
        }
    }
}
