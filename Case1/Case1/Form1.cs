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
            IBinaryCalculation binaryCalculation = FabricClass.CreateOperation(name);
            ThirdArgumentField.Text = binaryCalculation.Calculate(firstArgument, secondArgument);
        }
    }
}
