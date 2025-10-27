using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculatorr
{
    public partial class Form1 : Form
    {
        BasicComputation basicComputation = new BasicComputation();
        public Form1()
        {
            InitializeComponent();
            comboOperator.Items.Add("+");
            comboOperator.Items.Add("-");
            comboOperator.Items.Add("*");
            comboOperator.Items.Add("/");
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(num1Txt.Text);
            double secondNum = Convert.ToDouble(num2Txt.Text);
            double ans;

            if (comboOperator.SelectedIndex == 0)
            {
                ans = CalculatorPrivateAssembly.BasicComputation.Addition(firstNum, secondNum);
                totalLabel.Text = ans.ToString();
            }
            else if (comboOperator.SelectedIndex == 1)
            {
                ans = CalculatorPrivateAssembly.BasicComputation.Subtraction(firstNum, secondNum);
                totalLabel.Text = ans.ToString();
            }
            else if (comboOperator.SelectedIndex == 2)
            {
                ans = CalculatorPrivateAssembly.BasicComputation.Multiplication(firstNum, secondNum);
                totalLabel.Text = ans.ToString();
            }
            else if (comboOperator.SelectedIndex == 3) {
                ans = CalculatorPrivateAssembly.BasicComputation.Division(firstNum, secondNum);
                totalLabel.Text = ans.ToString();
            }
        }
    }
}
